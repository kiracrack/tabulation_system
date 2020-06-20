Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports System.IO

Module Synchronized
    Public Sub SynchuserAccounts()
        Dim synchdata As String = ""
        If System.IO.File.Exists(Application.StartupPath & "\" & file_users) = True Then
            System.IO.File.Delete(Application.StartupPath & "\" & file_users)
        End If

        com.CommandText = "select * from tblaccounts where officeid='" & compOfficeid & "' order by fullname asc" : rst = com.ExecuteReader
        While rst.Read
            synchdata = synchdata & rst("accountid").ToString & "|" & rst("fullname").ToString & "|" & rst("designation").ToString & Chr(13)
        End While
        rst.Close()

        Dim detailsFile As StreamWriter = Nothing
        detailsFile = New StreamWriter(file_users, True)
        detailsFile.WriteLine(synchdata)
        detailsFile.Close()
    End Sub
    Public Sub SynchRequestType()
        Dim synchdata As String = ""
        If System.IO.File.Exists(file_requesttype) = True Then
            System.IO.File.Delete(file_requesttype)
        End If

        com.CommandText = "select * from tblpurchasetype " : rst = com.ExecuteReader
        While rst.Read
            synchdata = synchdata & rst("potypeid").ToString & "|" & rst("description").ToString & Chr(13)
        End While
        rst.Close()

        Dim detailsFile As StreamWriter = Nothing
        detailsFile = New StreamWriter(file_requesttype, True)
        detailsFile.WriteLine(synchdata)
        detailsFile.Close()
    End Sub

    Public Sub SynchStockoutType()
        Dim synchdata As String = ""
        If System.IO.File.Exists(file_stockouttype) = True Then
            System.IO.File.Delete(file_stockouttype)
        End If

        com.CommandText = "select * from tblstockouttype " : rst = com.ExecuteReader
        While rst.Read
            synchdata = synchdata & rst("stockouttypeid").ToString & "|" & rst("description").ToString & Chr(13)
        End While
        rst.Close()

        Dim detailsFile As StreamWriter = Nothing
        detailsFile = New StreamWriter(file_stockouttype, True)
        detailsFile.WriteLine(synchdata)
        detailsFile.Close()
    End Sub

   
    Public Sub SynchBillingAndPayments()
        '# BILLINGS AND PAYMENTS INVENTORY
        dst = New DataSet
        msda = New MySqlDataAdapter("Select potrnid as 'Request Reference No.',  " _
                           + " (select officename from tblcompoffice where officeid=tblitemsrecieved.officeid) as 'Office', PRODUCTID as 'Particular ID', " _
                           + " (select ITEMNAME from tblglobalproducts where PRODUCTID=tblitemsrecieved.PRODUCTID) as 'Particular', " _
                           + " tblprocategory.description as 'Category', " _
                           + " Quantity, total as 'Amount', date_format(datetrn, '%Y-%m-%d %r') as 'Date Payments',(select companyname from tblglobalvendor where vendorid=tblitemsrecieved.vendorid) as 'Vendor', " _
                           + " reference as 'Reference No.', " _
                           + " Remarks, " _
                           + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from tblattachments where referenceno = tblitemsrecieved.potrnid),'-') as 'Attachment' " _
                           + " from tblitemsrecieved inner join tblprocategory on tblitemsrecieved.catid = tblprocategory.catid where uses=0 and status=0  and officeid = '" & compOfficeid & "'" _
                           + " ", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblitemsrecieved")
        dst.WriteXml(file_inventory_payments)
    End Sub

    Public Sub SynchConsumableInventory()
        com.CommandText = "delete from tblinventory where quantity=0 and officeid = '" & compOfficeid & "'" : com.ExecuteNonQuery()
        dst = New DataSet
        msda = New MySqlDataAdapter("Select trnid,officeid,tblinventory.catid, " _
                           + " PRODUCTID as 'Particular ID', " _
                           + " (select officename from tblcompoffice where officeid=tblinventory.officeid) as 'Office' , " _
                           + " ifnull((select stockhousename from tblstockhouse where stockhouseid=tblinventory.stockhouseid),'MAIN STOCK HOUSE') as 'Stock House', " _
                           + " (select ITEMNAME from tblglobalproducts where PRODUCTID=tblinventory.PRODUCTID) as 'Particular', " _
                           + " tblprocategory.description as 'Category', " _
                           + " QUANTITY as 'Available Quantity' , Unit,purchasedprice as 'Latest Cost',(purchasedprice*QUANTITY) as 'Total Cost', date_format(lastupdate, '%Y-%m-%d %r') as 'Last Update' " _
                           + " from tblinventory inner join tblprocategory on tblinventory.catid = tblprocategory.catid where uses=1 and quantity > 0 and officeid='" & compOfficeid & "' order by  (select ITEMNAME from tblglobalproducts where PRODUCTID=tblinventory.PRODUCTID) asc" _
                           + " ", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblinventory")
        dst.WriteXml(file_inventory_consumables)
    End Sub
    Public Sub SynchCFFEInventory()
        '# CFFE INVENTORY
        Dim dst As New DataSet
        msda = New MySqlDataAdapter("Select *,timestampdiff(month, datepurchased, current_date) as 'AsMonth', " _
                                            + " format(PERIOD_DIFF(date_format(current_date,'%Y%m'),date_format(datepurchased,'%Y%m'))/12,1) as `AsYear` from tbldeprecitionofassets inner join tblinventorybffe on tbldeprecitionofassets.catid = tblinventorybffe.catid where actived=1 and status=0 and officeid = '" & compOfficeid & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                If .Rows(cnt)("depmode").ToString() = "0" Then
                    com.CommandText = "update tblinventorybffe set age='" & .Rows(cnt)("AsYear").ToString() & " Year(s)', bookvalue=" & Val(CC(DepreciationReduce(.Rows(cnt)("total").ToString(), .Rows(cnt)("AsYear").ToString(), .Rows(cnt)("depvalue").ToString()))) & ",depreciationtype='Reducing Balance " & .Rows(cnt)("depvalue").ToString() & "%' where refcode='" & .Rows(cnt)("refcode").ToString() & "'" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "update tblinventorybffe set age='" & .Rows(cnt)("AsMonth").ToString() & " Month(s)', bookvalue=" & Val(CC(DepreciationStraight(.Rows(cnt)("total").ToString(), .Rows(cnt)("AsMonth").ToString(), .Rows(cnt)("depvalue").ToString()))) & ",depreciationtype='Straight Line " & .Rows(cnt)("depvalue").ToString() & " Year(s)' where refcode='" & .Rows(cnt)("refcode").ToString() & "'" : com.ExecuteNonQuery()
                End If
            End With
        Next

        dst = New DataSet
        msda = New MySqlDataAdapter("Select potrnid as 'PO Transaction Code',refcode as 'Inventory Code',officeid as 'Office ID',tblinventorybffe.catid as 'Category ID', " _
                           + " (select officename from tblcompoffice where officeid=tblinventorybffe.officeid) as 'Office' ,PRODUCTID as 'Particular ID', " _
                           + " (select ITEMNAME from tblglobalproducts where PRODUCTID=tblinventorybffe.PRODUCTID) as 'Particular', " _
                           + "ifnull((select stockhousename from tblstockhouse where stockhouseid=tblinventorybffe.stockhouseid),'MAIN STOCK HOUSE') as 'Stock House', " _
                           + " tblprocategory.description as 'Category', " _
                           + " QUANTITY as 'Quantity',Unit,cost as 'Unit Cost', Total, date_format(datepurchased, '%Y-%m-%d') as 'Date Purchased', " _
                           + " (select companyname from tblglobalvendor where vendorid=tblinventorybffe.vendorid) as 'Supplier', " _
                           + " reference as 'Reference No.', " _
                           + " Color, Brand, Model, Serial, remarks as 'Item Details', " _
                           + " Age," _
                           + " bookvalue as `Book Value`," _
                           + " (Total-bookvalue) as `Depreciated Amount`," _
                           + " depreciationtype as 'Depreciation Type', " _
                           + " ifnull((select fullname from tblaccounts where accountid = tblinventorybffe.acctableperson),'Not assigned yet') as 'Accountable Person', " _
                           + " ifnull(date_format(acctabledate, '%Y-%m-%d'),'-') as 'Date Issue', " _
                           + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from tblattachments where (referenceno = tblinventorybffe.potrnid or referenceno=tblinventorybffe.refcode)),'-') as 'Attachment', " _
                            + " case when actived=1 then 'Active' else 'Inactive' end as 'Status', " _
                           + " date_format(datetrn, '%Y-%m-%d %r') as 'Date Modified', (select fullname from tblaccounts where accountid = tblinventorybffe.trnby) as 'Modified By' " _
                           + " from tblinventorybffe inner join tblprocategory on tblinventorybffe.catid = tblprocategory.catid where uses=2 and status=0 and officeid='" & compOfficeid & "'" _
                           + " ", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblinventorybffe")
        dst.WriteXml(file_inventory_bffe)
    End Sub

    Public Sub SynchRequestParticular()
        '# REQUEST PARTICULAR
        dst = New DataSet
        msda = New MySqlDataAdapter("Select id, " _
                + " (select officename from tblcompoffice where officeid = tblproductrequest.officeid) as 'Office', " _
                + " itemname as 'Item Name', " _
                + " procost as 'Unit Cost', Unit, " _
                + " ifnull((select companyname from tblglobalvendor where vendorid = tblproductrequest.vendorid), 'Unregistered Vendor') as 'Vendor', " _
                + " Message,  date_format(DATEREQUEST,'%Y-%m-%d %r')  as 'Date Request', logs, " _
                + " CASE WHEN STATUS='0' THEN 'Received' WHEN STATUS='1' THEN 'Pending' WHEN STATUS='2' THEN 'Cancelled' END as 'Current Request Status', " _
                + " (select fullname from tblaccounts where accountid = tblproductrequest.requestid) as 'Request By' " _
                + " from tblproductrequest where officeid='" & compOfficeid & "' order by daterequest desc", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblproductrequest")
        dst.WriteXml(file_request_particular)
    End Sub
    Public Sub SynchRequestOnline()
        '# REQUEST ONLINE
        dst = New DataSet
        msda = New MySqlDataAdapter("Select pid as 'Request Code', " _
                    + " (select officename from tblcompoffice where officeid = tblprequesttitle.officeid) as 'Office', " _
                    + " (select fullname from tblaccounts where accountid = tblprequesttitle.REQUESTBY) as 'Request By' , " _
                    + " (select DESCRIPTION from tblpurchasetype where POTYPEID=tblprequesttitle.POTYPEID) as 'Request Type', " _
                    + " date_format(DATEREQUEST,'%Y-%m-%d %r') as 'Date Request', " _
                    + " Priority,withattachment as 'Attachment', details as Message, " _
                    + " (select fullname from tblaccounts where accountid = tblprequesttitle.requesttrnby) as 'Sender', " _
                    + " CASE WHEN STATUS='0' THEN 'Received' WHEN STATUS='1' THEN 'Pending' WHEN STATUS='2' THEN 'Cancelled' END as 'Current Request Status' " _
                    + " from tblprequesttitle where officeid = '" & compOfficeid & "' " _
                    + " order by DATEREQUEST desc", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblprequesttitle")
        dst.WriteXml(file_request_online)
    End Sub
    Public Sub SynchRequestReceived()
        '# MASTER REQUEST RECEIVED
        dst = New DataSet
        msda = New MySqlDataAdapter("Select officeid,PID as 'Request No', " _
                     + " (select officename from tblcompoffice where officeid = tblpurchasetitle.officeid) as 'Office', " _
                     + " (select fullname from tblaccounts where accountid = tblpurchasetitle.REQUESTBY) as 'Request By' , " _
                     + " date_format(DATEREQUEST, '%Y-%m-%d') as 'Date Request', " _
                     + " date_format(DATEREQUEST, '%r') as 'Time Request', " _
                     + " case when officedisbursement=0 then 'CORPORATE MAIN' else 'OFFICE' end as 'Disbursing Office', " _
                     + " (select DESCRIPTION from tblpurchasetype where POTYPEID=tblpurchasetitle.POTYPEID) as 'Request Type', " _
                     + " ifnull((select sum(total) from tblitemsrecieved where poid=tblpurchasetitle.pid),0) as 'Total Amount', " _
                     + " date_format(DATErecieved, '%Y-%m-%d') as 'Date Received', " _
                     + " date_format(DATErecieved, '%r') as 'Time Received', " _
                     + " (select fullname from tblaccounts where accountid = tblpurchasetitle.checkedby) as 'Checked by' , " _
                     + " CASE WHEN STATUS='0' THEN 'Received' WHEN STATUS='1' THEN 'Pending' WHEN STATUS='2' THEN 'Approved' WHEN STATUS='3' THEN 'Disapproved' WHEN STATUS='4' THEN 'Revised' WHEN STATUS='5' THEN 'Draft' END  as 'Status', " _
                     + " (select fullname from tblaccounts where accountid = tblpurchasetitle.PURCHASER) as 'Purchaser',  " _
                     + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from tblattachments where referenceno = tblpurchasetitle.pid or referenceno in (select potrnid from tblitemsrecieved where poid = tblpurchasetitle.pid)),'-') as 'Attachment' " _
                     + " from tblpurchasetitle " _
                     + " WHERE tblpurchasetitle.STATUS = '0' and officeid='" & compOfficeid & "' " _
                     + " order by DATERecieved desc", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblpurchasetitle")
        dst.WriteXml(file_request_received)
    End Sub
    Public Sub SynchRequestforApproval()
        '# MASTER REQUEST FOR APPROVAL
        dst = New DataSet
        msda = New MySqlDataAdapter("Select officeid,PID as 'Request No', " _
                      + " (select officename from tblcompoffice where officeid = tblpurchasetitle.officeid) as 'Office', " _
                      + " (select fullname from tblaccounts where accountid = tblpurchasetitle.REQUESTBY) as 'Request By' , " _
                      + " (select DESCRIPTION from tblpurchasetype where POTYPEID=tblpurchasetitle.POTYPEID) as 'Request Type', " _
                      + " ifnull((select sum(total) from tblpurchaseitem where purchaseid=tblpurchasetitle.pid),0) as 'Total Amount', " _
                      + " date_format(DATEREQUEST, '%Y-%m-%d') as 'Date Request', " _
                      + " date_format(DATEREQUEST, '%r') as 'Time Request', " _
                      + " case when officedisbursement=0 then 'CORPORATE MAIN' else 'OFFICE' end as 'Disbursing Office', " _
                      + " CASE WHEN STATUS='0' THEN 'Received' WHEN STATUS='1' THEN 'Pending' WHEN STATUS='2' THEN 'Approved' WHEN STATUS='3' THEN 'Disapproved' WHEN STATUS='4' THEN 'Revised' WHEN STATUS='5' THEN 'Draft' END  as 'Status', " _
                      + " (select (select fullname from tblaccounts where accountid = tblforapproval.receiver) from tblforapproval where tblforapproval.poid = tblpurchasetitle.pid and tblforapproval.status=1 ) as 'Current Approver', " _
                      + " (select CASE WHEN STATUS = '1' THEN 'Approved' WHEN STATUS = '2' THEN 'Disaproved'  WHEN STATUS = '3' THEN 'For Revision' END from tblapprovalhistory where poid = tblpurchasetitle.pid order by dateconfirm desc limit 1) as 'Last Approval Status', " _
                      + " (select fullname from tblaccounts where accountid = tblpurchasetitle.PURCHASER) as 'Purchaser',  " _
                      + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from tblattachments where referenceno = tblpurchasetitle.pid or referenceno in (select trnid from tblpurchaseitem where purchaseid = tblpurchasetitle.pid)),'-') as 'Attachment' " _
                      + " from tblpurchasetitle " _
                      + " WHERE (tblpurchasetitle.STATUS = '1' or tblpurchasetitle.STATUS = '5') and officeid='" & compOfficeid & "'" _
                      + " order by DATEREQUEST desc", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblpurchasetitle")
        dst.WriteXml(file_request_pending)
    End Sub
    Public Sub SynchRequestApproved()
        '# MASTER REQUEST APPROVED
        dst = New DataSet
        msda = New MySqlDataAdapter("Select officeid, PID as 'Request No', " _
                     + " (select officename from tblcompoffice where officeid = tblpurchasetitle.officeid) as 'Office', " _
                     + " (select fullname from tblaccounts where accountid = tblpurchasetitle.REQUESTBY) as 'Request By' , " _
                     + " date_format(DATEREQUEST, '%Y-%m-%d') as 'Date Request', " _
                     + " date_format(DATEREQUEST, '%r') as 'Time Request', " _
                     + " (select DESCRIPTION from tblpurchasetype where POTYPEID=tblpurchasetitle.POTYPEID) as 'Request Type', " _
                     + " ifnull((select sum(total) from tblpurchaseitem where purchaseid=tblpurchasetitle.pid),0) as 'Total Amount', " _
                     + " date_format(DATEAPPROVAL, '%Y-%m-%d') as 'Date Approved', " _
                     + " date_format(DATEAPPROVAL, '%r') as 'Time Approved', " _
                     + " case when officedisbursement=0 then 'CORPORATE MAIN' else 'OFFICE' end as 'Disbursing Office', " _
                     + " CASE WHEN STATUS='0' THEN 'Received' WHEN STATUS='1' THEN 'Pending' WHEN STATUS='2' THEN 'Approved' WHEN STATUS='3' THEN 'Disapproved' WHEN STATUS='4' THEN 'Revised' WHEN STATUS='5' THEN 'Draft' END  as 'Status', " _
                     + " (select fullname from tblaccounts where accountid = tblpurchasetitle.PURCHASER) as 'Purchaser', " _
                     + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from tblattachments where referenceno = tblpurchasetitle.pid or referenceno in (select trnid from tblpurchaseitem where purchaseid = tblpurchasetitle.pid)),'-') as 'Attachment' " _
                     + " from tblpurchasetitle " _
                     + " WHERE tblpurchasetitle.STATUS= '2' and officeid= '" & compOfficeid & "'" _
                     + " order by DATEAPPROVAL desc", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblpurchasetitle")
        dst.WriteXml(file_request_approved)
    End Sub
    Public Sub SynchRequestDisapproved()
        '# MASTER REQUEST DISAPPROVED
        dst = New DataSet
        msda = New MySqlDataAdapter("Select officeid,PID as 'Request No', " _
                     + " (select officename from tblcompoffice where officeid = tblpurchasetitle.officeid) as 'Office', " _
                     + " (select fullname from tblaccounts where accountid = tblpurchasetitle.REQUESTBY) as 'Request By' , " _
                     + " date_format(DATEREQUEST, '%Y-%m-%d') as 'Date Request', " _
                     + " date_format(DATEREQUEST, '%r') as 'Time Request', " _
                     + " (select DESCRIPTION from tblpurchasetype where POTYPEID=tblpurchasetitle.POTYPEID) as 'Request Type', " _
                     + " ifnull((select sum(total) from tblpurchaseitem where purchaseid=tblpurchasetitle.pid),0) as 'Total Amount', " _
                     + " date_format(DATEAPPROVAL, '%Y-%m-%d') as 'Date Disapproved', " _
                     + " date_format(DATEAPPROVAL, '%r') as 'Time Disapproved', " _
                     + " case when officedisbursement=0 then 'CORPORATE MAIN' else 'OFFICE' end as 'Disbursing Office', " _
                     + " CASE WHEN STATUS='0' THEN 'Received' WHEN STATUS='1' THEN 'Pending' WHEN STATUS='2' THEN 'Approved' WHEN STATUS='3' THEN 'Disapproved' WHEN STATUS='4' THEN 'Revised' WHEN STATUS='5' THEN 'Draft' END  as 'Status', " _
                     + " (select fullname from tblaccounts where accountid = tblpurchasetitle.PURCHASER) as 'Purchaser',  " _
                     + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from tblattachments where referenceno = tblpurchasetitle.pid or referenceno in (select trnid from tblpurchaseitem where purchaseid = tblpurchasetitle.pid)),'-') as 'Attachment' " _
                     + " from tblpurchasetitle " _
                     + " WHERE tblpurchasetitle.STATUS= '3' and officeid='" & compOfficeid & "'" _
                     + " order by DATEAPPROVAL desc", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblpurchasetitle")
        dst.WriteXml(file_request_cancelled)

    End Sub
    Public Sub SynchIncomingTransferRequest()
        '# MASTER REQUEST INCOMING
        dst = New DataSet
        msda = New MySqlDataAdapter("Select batchcode as 'Batch Code', inventory_from, (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_from) as 'From', " _
                      + " (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_to) as 'To', " _
                      + " Note, " _
                      + " (select fullname from tblaccounts where accountid = tbltransferbatch.requestby) as 'Request By' , " _
                      + " date_format(datetransfer,'%Y-%m-%d %r')  as 'Date Request', " _
                      + " (select fullname from tblaccounts where accountid = tbltransferbatch.trnby) as 'Created' , " _
                      + " case when confirmed=0 then 'Not yet Confirm' when confirmed=1 then 'Confirmed' else 'Cancelled' end as 'Status', DATEDIFF(current_date,datetransfer) as 'Day(s) Count' from tbltransferbatch where confirmed=0 " _
                      + " and inventory_to='" & compOfficeid & "' order by datetransfer desc", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tbltransferitem")
        dst.WriteXml(file_request_incoming_transfer)
    End Sub
    Public Sub SynchParticularReceived()
        '# MASTER REQUEST INCOMING
        dst = New DataSet
        msda = New MySqlDataAdapter("Select poid, potrnid,officeid, " _
                           + " (select officename from tblcompoffice where officeid=tblitemsrecieved.officeid) as 'Office' , " _
                           + " PRODUCTID as 'Particular ID', " _
                           + " (select ITEMNAME from tblglobalproducts where PRODUCTID=tblitemsrecieved.PRODUCTID) as 'Particular', " _
                           + " (select description from tblprocategory where catid=tblitemsrecieved.catid) as 'Category', " _
                           + " QUANTITY as 'Quantity', " _
                           + " UNIT as 'Unit', " _
                           + " COST as 'Unit Price', Total as 'Total Amount'," _
                           + " DATETRN as 'Date Recieved', " _
                           + " (select companyname from tblglobalvendor where vendorid=tblitemsrecieved.vendorid) as 'Vendor', " _
                           + " REMARKS as 'Remarks' " _
                           + " from tblitemsrecieved  where status='0' and officeid='" & compOfficeid & "' order by DATETRN desc", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblitemsrecieved")
        dst.WriteXml(file_particular_received)
    End Sub
    Public Sub SynchParticularRequested()
        dst = New DataSet
        msda = New MySqlDataAdapter("Select trnid,purchaseid as poid,(select ITEMNAME from tblglobalproducts where PRODUCTID = tblpurchaseitem.PRODUCTID ) as 'Particular Item', " _
                      + " QUANTITY as 'Quantity'," _
                      + " UNIT as 'Unit', " _
                      + " COST as 'Unit Price', " _
                      + " TOTAL as 'Total Amount', " _
                      + " tblpurchaseitem.Remarks, " _
                      + " (select COMPANYNAME from tblglobalvendor where vendorid = tblpurchaseitem.vendorid ) as 'Vendor' " _
                      + " from tblpurchaseitem inner join tblpurchasetitle on tblpurchaseitem.purchaseid =  tblpurchasetitle.pid " _
                      + " where officeid='" & compOfficeid & "'", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblpurchaseitem")
        dst.WriteXml(file_particular_requested)
    End Sub
    Public Sub SynchGlobalProducts()
        dst = New DataSet
        msda = New MySqlDataAdapter("Select catid,  (select uses from tblprocategory where CATID = tblglobalproducts.CATID) as 'cattype', PRODUCTID as 'Item Code', " _
                           + " ITEMNAME as 'Particulars', " _
                           + " (select DESCRIPTION from tblprocategory where CATID = tblglobalproducts.CATID) as 'Category',Unit, " _
                           + " ifnull(ifnull((select procost from tblitemvendor where officeid='" & compOfficeid & "' and itemid = tblglobalproducts.productid order by lastupdate asc limit 1), (select purchasedprice from tblinventory where productid=tblglobalproducts.productid and officeid = '" & compOfficeid & "' limit 1)),0) as 'Latest Cost' " _
                           + " from tblglobalproducts " _
                           + " order by ITEMNAME asc", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblglobalproducts")
        dst.WriteXml(file_global_items)
    End Sub
    Public Sub SynchGlobalitemvendors()
        dst = New DataSet
        msda = New MySqlDataAdapter("SELECT officeid, vendorid,itemid, " _
                                   + " (select COMPANYNAME from tblglobalvendor where vendorid = tblitemvendor.vendorid) as 'Vendor/Supplier', " _
                                   + "  procost as 'Unit Price'" _
                                   + " from tblitemvendor order by  (select COMPANYNAME from tblglobalvendor where vendorid = tblitemvendor.vendorid) desc", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblitemvendor")
        dst.WriteXml(file_global_itemvendors)

        dst = New DataSet
        msda = New MySqlDataAdapter("Select vendorid as 'Vendor ID', " _
                  + " COMPANYNAME as 'Select Vendor', " _
                  + " COMPADD as 'Address' from tblglobalvendor order by COMPANYNAME asc", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblglobalvendor")
        dst.WriteXml(file_global_vendors)
    End Sub
    Public Sub SynchStockouts()
        dst = New DataSet
        msda = New MySqlDataAdapter("SELECT batchcode as 'Batch Code'," _
                           + " (select officename from tblcompoffice where officeid = tblstockoutbatch.officeid) as 'Office', " _
                           + " date_format(periodfrom, '%Y-%m-%d') as 'Period From', " _
                           + " date_format(periodto, '%Y-%m-%d') as 'Period To', " _
                           + " (select fullname as FULLNAME from tblaccounts where accountid=tblstockoutbatch.trnby) as 'Created by', " _
                           + "  date_format(DATEstockout,'%Y-%m-%d %r') as 'Date Created', Remarks   " _
                           + " from tblstockoutbatch where officeid='" & compOfficeid & "'" _
                           + " order by DATEstockout desc", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblstockoutbatch")
        dst.WriteXml(file_stockouts_summary)


        dst = New DataSet
        msda = New MySqlDataAdapter("Select batchcode, stockouttypeid, productid as 'Item Code', (select description from tblprocategory where CATID = tblstockoutitem.CATID) as 'Category', " _
                            + "(select ITEMNAME from tblglobalproducts where PRODUCTID=tblstockoutitem.PRODUCTID) as 'Item Name', Quantity,Unit , date_format(datetrn,'%Y-%m-%d %r') as 'Stockout Date' " _
                         + " from tblstockoutitem " _
                         + " where fromofficeid ='" & compOfficeid & "'", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblstockoutitem")
        dst.WriteXml(file_stockouts_items)
    End Sub

    Public Function SynchCurrentStockoutitem()
        Dim currentStockoutCode As String = ""
        Dim thisMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        com.CommandText = "select * from tblstockoutbatch where periodfrom='" & thisMonth.ToString("yyyy-MM-01") & "' and periodto='" & thisMonth.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd") & "' and officeid='" & compOfficeid & "'" : rst = com.ExecuteReader
        While rst.Read
            currentStockoutCode = rst("batchcode").ToString
        End While
        rst.Close()
        dst = New DataSet
        msda = New MySqlDataAdapter("Select batchcode, (select ITEMNAME from tblglobalproducts where PRODUCTID=tblstockoutitem.PRODUCTID) as 'Item Name', " _
                         + " (select description from tblprocategory where CATID = tblstockoutitem.CATID) as 'Category', " _
                         + " Quantity,Unit ,Remarks, " _
                         + " (select fullname as FULLNAME from tblaccounts where accountid=tblstockoutitem.requestby) as 'Requested by', " _
                         + " date_format(datetrn,'%Y-%m-%d %r') as 'Date Created', " _
                         + " (select fullname from tblaccounts where accountid = tblstockoutitem.trnby) as 'Transaction By' " _
                         + " from tblstockoutitem " _
                         + " where fromofficeid='" & compOfficeid & "' and batchcode ='" & currentStockoutCode & "'", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblstockoutitem")
        dst.WriteXml(file_stockouts_current)
        Return 0
    End Function

    Public Function SynchNotifications()
        dst = New DataSet
        msda = New MySqlDataAdapter("Select n_description as 'Details', (select fullname from tblaccounts where accountid = tblnotifylist.n_by) as 'Action By', date_format(n_datetime,'%Y-%m-%d %r') as 'Date Action' from tblnotifylist " _
                         + " where officeid='" & compOfficeid & "' order by n_datetime asc", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblnotifylist")
        dst.WriteXml(file_notifications)
        Return 0
    End Function
End Module

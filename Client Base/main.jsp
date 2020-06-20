<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<%@ include file="kickass/db.jsp"%>
<%@ page errorPage="main.jsp?url=" %>
<% String errorCatch=request.getParameter("status"); if (errorCatch==null){errorCatch="";}if(errorCatch==""){errorCatch="";}  %>
<%
try{
	String urls = "";
	String catchurl=request.getParameter("url");	
%>

<head>
<meta http-equiv="Content-Type" content="text/html; charset=windows-1252" />
<title><%=GlobalEventCategory%></title>
<link rel="stylesheet" type="text/css" href="style.css" />
<link rel="stylesheet" type="text/css" href="table.css" />
<link rel="icon" href="images/ico.gif" type="image/x-icon" />
</head>
<body>
<%
	String loguser="";
	String ids="";
	if(session.getAttribute("username")!=null && session.getAttribute("username")!=""){ 
	}else{
	response.sendRedirect("index.jsp");
	}
%>

<script type="text/javascript" src="js/wz_tooltip.js"></script>
<%
if(session.getAttribute("username")!=null && session.getAttribute("username")!=""){ 
 		sqlquery = "select * from tbljudges where judgeid='" + session.getAttribute("userid") + "'"; 
		rst =  stmt.executeQuery(sqlquery);
		while(rst.next()){
			Jid= rst.getString("judgeid");	
			JNo= rst.getString("judgeNumber");		
			Jfullname= rst.getString("JudgeName");		
			Jstat= rst.getString("status");
		}

      if (Jstat.equals("6") || Jstat.equals("0")){
          response.sendRedirect("login/logout.jsp");
  }

	}
%> 

<div id="main_container">

	<div id="header">
    <div class="logo" style="display:none">
    <a href="index.html"><img src="images/logo.gif" alt="" title="" border="0" /></a>
    </div>
    
    </div>
    <div>&nbsp;</div>

    <div id="main_content">
   	  <div class="center_content">

           
            
<div class="log_block">
        <table width="718" height="39"><tr><td class="log">Welcome Judged #<%=JNo%>: <%=Jfullname%></td><td align="right"><a href="login/logout.jsp"><strong>LOGOUT</strong></a></td></tr></table></div>
		</div>     
            
<!-- First Content Area  --> <!-- End First Content Area  -->
<%@ include file="template/title.jsp"%>
<!-- Content Area -->  
<div class="products">
            	<!--<div class="title"><img src="images/title_products.gif" alt="" title="" /></div> -->
                <div class="products_box">                                  
                <div class="clear"></div>
                



                </div>
   	  </div>
             <!-- End Content Area -->
         	 <div class="clear"></div>  
 <%@ include file="template/footer.jsp"%>
  </div>
 </div>
</div> 
  
</div>
<script language="JavaScript" type="text/javascript">
<!--
function checkform ( form )
{
  <%
  float fscore = 0;
  String strCat = "select * from tblcriteriaforjudging where eventid='" + GlobalEventID + "' and categoryid='" + GlobalCategoryId + "' order by sortOrder asc"; 
  rs =  st.executeQuery(strCat);
  while(rs.next()){
      String dbscore=rs.getString("criteriaScore");
      fscore = Float.parseFloat(dbscore);
    %>

  if (form("score<%=rs.getString("criteriaid")%>").value == "" || form("score<%=rs.getString("criteriaid")%>").value == 0 ) {
    alert( "Please enter your valid <%=rs.getString("criteriaName")%> score." );
    form("score<%=rs.getString("criteriaid")%>").focus();
    return false ;
    
  }else if(form("score<%=rs.getString("criteriaid")%>").value > <%=fscore%>) {
    alert( "The Maximum of <%=rs.getString("criteriaName")%> score is <%=rs.getString("criteriaScore")%>." );
    form("score<%=rs.getString("criteriaid")%>").focus();
    return false ;
  }

  <%}%>
  return true ;
}
</script>
<%}catch(Exception e){
	out.print(e);
}%>
</body>    
</html>
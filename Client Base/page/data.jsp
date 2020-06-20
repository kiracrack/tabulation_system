 <div style="padding:20px;"> 
 <%if(errorCatch.equals("invalid")){%>
 		<div align="center" style="background:#FF9; width:auto;color:red;font-size:14px; margin:10px 15px 15px 15px; padding:20px; border: 1px solid #F60">
 		<strong>Action not allowed! Please submit a proper score and should be <br/> greater than zero and less than score limit</strong></div> 
	<%}%>
 <p style="display:none">
 <%
 out.print(GlobalRankCode);
 out.print(GlobalEventID);
 %>
 </p>
<%
try{
sqlquery = "select tblcontestant.*,format(PERIOD_DIFF(date_format(current_date,'%Y%m'),date_format(birthDate,'%Y%m'))/12,0) as 'Age' from tblactivatedcontestant inner join tblcontestant on tblactivatedcontestant.contestantid = tblcontestant.contestantid  where tblactivatedcontestant.eventid='" + GlobalEventID + "' and rankid='" + GlobalRankCode + "' and tblactivatedcontestant.batchcode='" + GlobalBatchCode + "' order by contestantNumber asc"; 
rst =  stmt.executeQuery(sqlquery);
while(rst.next()){
		
		int scorecount = 0;
		String sqlScoreQuery = "select * from tblscores where eventid='" + GlobalEventID + "' and judgeid='" + Jid + "' and contestantid='" + rst.getString("contestantid") + "' and categoryid='" + GlobalCategoryId + "'";
		rs =  st.executeQuery(sqlScoreQuery);
		while(rs.next()){
			scorecount++;		 
		}
		if (scorecount==0){%>
					<form action="process/submit.jsp" onsubmit="return checkform(this);" method="post">
           			<div id="c<%=rst.getString("contestantNumber")%>"></div> 
					<table style="margin-bottom:5px; padding:10px; ">
						<tr>
							<td width="110" align="center" style="font-size:80px; font-family:arial black;"><%=rst.getString("contestantNumber")%></td>
							<td  width="300" align="center"> 
								<% if(GlobalWithImage==true){%><img src="candidates/thumb/<%=rst.getString("contestantNumber")%>.jpg" width="128"   onMouseOver="Tip('<img align=\'left\' src=\'candidates/large/<%=rst.getString("contestantNumber")%>.jpg\' width=\'200\' style=\'margin-right:10px\'  >', FADEIN, 500, FADEOUT, 1000, PADDING, 10, BGCOLOR,'#b5e1ff', TITLE, '<%=rst.getString("contestantName")%>', TEXTALIGN, 'left', WIDTH, 200, FONTFACE, 'Trebuchet MS, mono');" onMouseOut="UnTip()" /> <br/><br/><%}%>
								<span class="cname"><%=rst.getString("contestantName")%></span><br />Representative of <%=rst.getString("representativePlace")%><br/>
								<% if(!rst.getString("Age").equals("0")){%> Age:  <%=rst.getString("Age")%> <%}%> </td>
							<td>	
								<table>				
                 				<%
									int countSubcati = 0;
									String strSub = "select *, concat('<li>', REPLACE(REPLACE(description, '\n', '</li><li>'), '\r', ''),'</li>') as des from tblcriteriaforjudging where eventid='" + GlobalEventID + "' and  categoryid='" + GlobalCategoryId + "' order by sortOrder asc"; 
									rs =  st.executeQuery(strSub);
									while(rs.next()){
									countSubcati ++; %>
                                       
                     				<tr>
                       					<td width="300" class="categorytitle"  onMouseOver="Tip('<%=rs.getString("des")%>', FADEIN, 500, FADEOUT, 1000, PADDING, 10, BGCOLOR,'#b5e1ff', TITLE, '<%=rs.getString("criteriaName")%>', TEXTALIGN, 'left', WIDTH, 500, FONTFACE, 'Trebuchet MS, mono');" onMouseOut="UnTip()" /><%=rs.getString("criteriaName")%> (<%=rs.getString("criteriaScore")%> %)</td>
                       					<td>
						 				<% if(GlobalScoreType.equals("SINGLE")){%>
												<select name="score<%=rs.getString("criteriaid")%>" class="score">
                	           						<option value="">Select</option>	
							   					<%for(int i=Integer.parseInt(rs.getString("criteriaScore"));i>=1;i--){%>
													<option value="<%=i%>"><%=i%></option>
                               				<%}%>
												</select>
										<%}else{%>
												<input type="text"  style="text-align:center"  name="score<%=rs.getString("criteriaid")%>" class="score" value="">
										<%}%>
										<input type="hidden" name="subid<%=countSubcati%>" value="<%=rs.getString("criteriaid")%>">
					    				</td>
                       
                    				</tr>
                     				<%}%>
                     				<tr><td colspan="2" align="right"><input type="submit" name="sumbit" value="Submit Score"/></td></tr>
                     			</table>
                     		</td>
					 <%String strCount = "select count(*) as cnt from tblcriteriaforjudging where eventid='" + GlobalEventID + "' and categoryid='" + GlobalCategoryId + "'"; 
							rs =  st.executeQuery(strCount);
						while(rs.next()){%>
						<input type="hidden" name="subno" value="<%=rs.getString("cnt")%>">
						<%}%>
						<input type="hidden" name="contestantno" value="<%=rst.getString("contestantNumber")%>">
					    <input type="hidden" name="contestantid" value="<%=rst.getString("contestantid")%>">
                        <input type="hidden" name="judgeid" value="<%=Jid%>">
              		</table>
                    </form>
                    <div class="title" align="center"></div>
		<%}else{%>
               	 <form action="process/submit.jsp" onsubmit="return checkform(this);" method="post">
           			<div id="c<%=rst.getString("contestantNumber")%>"></div> 
					<table style="background:#fff997; margin-bottom:5px; padding:10px;">
						<tr>
							<td width="110" align="center" style="font-size:80px; font-family:arial black; "><%=rst.getString("contestantNumber")%></td>
							<td  width="300" align="center"> 
							<% if(GlobalWithImage==true){%><img src="candidates/thumb/<%=rst.getString("contestantNumber")%>.jpg" width="128"   onMouseOver="Tip('<img align=\'left\' src=\'candidates/large/<%=rst.getString("contestantNumber")%>.jpg\' width=\'200\' style=\'margin-right:10px\'  >', FADEIN, 500, FADEOUT, 1000, PADDING, 10, BGCOLOR,'#b5e1ff', TITLE, '<%=rst.getString("contestantName")%>', TEXTALIGN, 'left', WIDTH, 200, FONTFACE, 'Trebuchet MS, mono');" onMouseOut="UnTip()" /> <br/><br/><%}%>
								<span class="cname"><%=rst.getString("contestantName")%></span><br />Representative of <%=rst.getString("representativePlace")%><br/> 
								<% if(!rst.getString("Age").equals("0")){%> Age:  <%=rst.getString("Age")%> <%}%> </td>
							<td>	
								<table>				
                 				<%
									int countSubcati = 0;
									String strSub = "select *, concat('<li>', REPLACE(REPLACE(description, '\n', '</li><li>'), '\r', ''),'</li>') as des from tblcriteriaforjudging where eventid='" + GlobalEventID + "' and  categoryid='" + GlobalCategoryId + "' order by sortOrder asc"; 
									rs =  st.executeQuery(strSub);
									while(rs.next()){
									countSubcati ++; 

										String ScoreSubmited = "";
										String strScore = "select * from tblscores where eventid='" + GlobalEventID + "' and rankid='" + GlobalRankCode + "' and categoryid='" + GlobalCategoryId + "' and judgeid='" + Jid + "' and contestantid='" + rst.getString("contestantid") + "' and criteriaid= '" + rs.getString("criteriaid") + "'"; 
										cst =  ct.executeQuery(strScore);
										while(cst.next()){
											ScoreSubmited = cst.getString("score");
										 }

									%>
                                       
                     				<tr>
                       					<td width="300"  class="categorytitle"  onMouseOver="Tip('<%=rs.getString("des")%>', FADEIN, 500, FADEOUT, 1000, PADDING, 10, BGCOLOR,'#b5e1ff', TITLE, '<%=rs.getString("criteriaName")%>', TEXTALIGN, 'left', WIDTH, 500, FONTFACE, 'Trebuchet MS, mono');" onMouseOut="UnTip()" /><%=rs.getString("criteriaName")%> (<%=rs.getString("criteriaScore")%> %)</td>
                       					<td>
						 				<% if(GlobalScoreType.equals("SINGLE")){%>
												<select name="score<%=rs.getString("criteriaid")%>" class="score">
                	           						<option value="<%=ScoreSubmited%>">Select</option>	
							   					<%for(int i=Integer.parseInt(rs.getString("criteriaScore"));i>=1;i--){%>
													<option value="<%=i%>"><%=i%></option>
                               				<%}%>
												</select>
										<%}else{%>
												<input type="text"  style="text-align:center"  name="score<%=rs.getString("criteriaid")%>" class="score" value="<%=ScoreSubmited%>">
										<%}%>
										<input type="hidden" name="subid<%=countSubcati%>" value="<%=rs.getString("criteriaid")%>">
					    				</td>
                       
                    				</tr>
                     				<%}%>
                     				<tr>
                     				<%
										String TotalScore = "";
										String strScore = "select format(sum(score),2) as ttl from tblscores where eventid='" + GlobalEventID + "' and rankid='" + GlobalRankCode + "' and categoryid='" + GlobalCategoryId + "' and judgeid='" + Jid + "' and contestantid='" + rst.getString("contestantid") + "'"; 
										cst =  ct.executeQuery(strScore);
										while(cst.next()){
											TotalScore = cst.getString("ttl");
										 }
                     				%>
                       					<td class="categorytitle"  style="font-size:15px;;"><strong>TOTAL SCORE</strong></td>
                       					<td align="center" style="font-size:25px; font-family:arial;"><%=TotalScore%></td>
                       
                    				</tr>
                     				<tr><td colspan="2" align="right"><input type="submit" name="sumbit" value="Submit Score"/></td></tr>
                     			</table>
                     		</td>
					 <%String strCount = "select count(*) as cnt from tblcriteriaforjudging where eventid='" + GlobalEventID + "' and categoryid='" + GlobalCategoryId + "'"; 
							rs =  st.executeQuery(strCount);
						while(rs.next()){%>
						<input type="hidden" name="subno" value="<%=rs.getString("cnt")%>">
						<%}%>
						<input type="hidden" name="contestantno" value="<%=rst.getString("contestantNumber")%>">
					    <input type="hidden" name="contestantid" value="<%=rst.getString("contestantid")%>">
                        <input type="hidden" name="judgeid" value="<%=Jid%>">
              		</table>
                    </form>
                    <div class="title" align="center"></div>
		<%}				
	}
		int TotalContestant = 0;
		String strTotalContestant = "select count(*) as ttl from tblactivatedcontestant where eventid='" + GlobalEventID + "' and rankid='" + GlobalRankCode + "'"; 
		cst =  ct.executeQuery(strTotalContestant);
		while(cst.next()){
			TotalContestant = cst.getInt("ttl");
		}

		int TotalSumitedContestant = 0;
		String strTotalSumitedContestant = "select count(distinct(contestantid)) as ttl from tblscores where eventid='" + GlobalEventID + "' and rankid='" + GlobalRankCode + "' and categoryid='" + GlobalCategoryId + "' and judgeid='" + Jid + "'"; 
		cst =  ct.executeQuery(strTotalSumitedContestant);
		while(cst.next()){
			TotalSumitedContestant = cst.getInt("ttl");
		}
	%>
	<%if(TotalContestant==TotalSumitedContestant){%>
	<div align="center" style="margin-top:10px;"><a href="process/update.jsp?judgedid=<%=Jid%>&currentStatus=<%=Jstat%>"><input class="nextcat" type="button" value="Confirm and Show score summary" /></a></div>
	<%}%>
<%}catch(Exception e){
		out.print(e);
      e.printStackTrace();
}
%>  
</div>
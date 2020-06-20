
<%
if(Jstat.equals("5")){
			 %> 
			 <div style="font-size:30px; font-family:Myriad Pro Cond; padding-top:10px; font-weight:bold" align="center">WELCOME TO <%=GlobalEventTitle.toUpperCase() %></div><br />
			  <div align="justify" style="width:500px; font-size:14px; margin:10px 15px 15px 120px; padding:20px; border: 1px solid #F60"><b>Technical explanation on how to use:</b>
			  <ol>
			  	<li style="padding:5px">After proceeding to next page. Your account's status will change as standby mode while waiting the tabulator account activation.</li>
			  	<li style="padding:5px">The Judges will be informed by the tabulator that their account are already activated. And the judges can proceed to score page.</li>
			  	<li style="padding:5px">In the score page. After fill-in the score field of every candidate, it must be submitted respectively.</li>
			  	<li style="padding:5px">After scoring, judges should confirm the overall score in order to proceed to "score summary page" by clicking "Confirm and Show score summary"</li>
			  	<li style="padding:5px">In the score summary page. The tabulator will send the generated copy from tabulation system of official result of every category and to be reviewed and sign by each judges confirming that their score are correct and accurate before clicking "Certified Correct" button</li>
			  </ol>
			  </div> 
	<%if(errorCatch.equals("error")){%>
 		<div align="justify" style="background:#FF9; width:500px;color:red;font-size:20px; margin:10px 15px 15px 120px; padding:20px; border: 1px solid #F60">
 		<strong>Action not allowed due to account restriction!</strong></div>	 
	<%}%>        
		<div align="center"><a href="process/update.jsp?judgedid=<%=Jid%>&currentStatus=<%=Jstat%>"><input class="nextcat" type="button" value="Proceed" /></a></div>


<%}else if (Jstat.equals("1")){%>

			 <div style="font-size:50px; font-family:Myriad Pro Cond black; padding-top:10px" align="center"><br/><img src="images/logo.PNG" width="400"/></div>
    
    <%if(errorCatch.equals("error")){%>
 		<div align="justify" style="background:#FF9; width:500px;color:red;font-size:20px; margin:10px 15px 15px 120px; padding:20px; border: 1px solid #F60">
 		<strong>Action not allowed due to account restriction!</strong></div> 
	<%}%>
             <div align="justify" style="background:#FF9; width:500px; font-size:20px; margin:10px 15px 15px 120px; padding:20px; border: 1px solid #F60">
             <strong>Please wait for a moment of the tabulator activation</strong></div>
             
<div align="center"><a href="main.jsp"><input class="nextcat" type="button" value="Start Scoring" /></a></div>

<%}else if (Jstat.equals("2") || Jstat.equals("3")){%>
<div class="welcome_block"><div class="title" align="center">
 <%=GlobalCategoryDescription%>
</div></div> 
	 <%@ include file="../page/data.jsp"%>

<%}else if (Jstat.equals("4")){%>
<div class="welcome_block"><div class="title" align="center">
SCORE SUMMARY REVIEW
</div></div> 
 	<%@ include file="../page/review.jsp"%>
<%}%>


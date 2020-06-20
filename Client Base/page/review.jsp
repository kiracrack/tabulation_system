 <div style="padding:20px;"> 
<%try{%>
<table id="background-image" align="center">
    <thead><tr><th colspan="4" scope="col"  style="background:#FFF"><h1><%=GlobalCategoryDescription%></h1></th></tr></thead>
    <thead>
    	<tr>
        	<th scope="col" align="center">No.</th>
            <th scope="col"><%=GlobalContestantType%></th>
            <th scope="col" align="center">Score</th>
            <th scope="col" align="center">Rank</th>
        </tr>
    </thead>
    <tfoot>
    	<tr>
        	<td colspan="5">Note: Please review your score and sign the generated result from tabulation system before clicking "Certified Correct"</td>
        </tr>
    </tfoot>
    <tbody>
    	<%
    	float curtotal =  0;
		int r = 1;
		int t = 0;
		int temp = 1;
		String sqlReview = "select (select contestantNumber from tblcontestant where contestantid=tblscores.contestantid) as 'c_number', (select contestantName from tblcontestant where contestantid=tblscores.contestantid) as 'c_name', format(sum(score),2) as total from tblscores  inner join tblcontestant on tblscores.contestantid = tblcontestant.contestantid where tblscores.eventid='" + GlobalEventID + "' and tblscores.judgeid='" + Jid + "' and tblscores.categoryid='" + GlobalCategoryId + "' and tblcontestant.batchcode='" + GlobalBatchCode + "' group by tblscores.contestantid order by sum(score) desc";
		rs =  st.executeQuery(sqlReview);
		while(rs.next()){%>
        <tr>
        	<td align="center"><%=rs.getString("c_number")%></td>
        	<td><%=rs.getString("c_name")%></td>
        	<td align="center"><%=rs.getString("total")%></td>

        	<%//RANKING
			if(rs.getFloat("total") < curtotal){
					r = r + 1 + t;
					t = 0;
			}else{
					r = r;
				if(temp != 1){
					t = t + 1;
				}
					temp = 0;	
			}
			curtotal = rs.getFloat("total");
			%>
        	<td align="center"><%=r%></td>
       	</tr>
        <%}%>
      
    </tbody>
</table>
 	<%if(errorCatch.equals("error")){%>
 		<div align="justify" style="background:#FF9; width:500px;color:red;font-size:20px; margin:10px 15px 15px 120px; padding:20px; border: 1px solid #F60">
 		<strong>Action not allowed due to account restriction!</strong></div>
	<%}%>
	<%if(GlobalCategoryLast==true){%>
		<div align="center" style="margin-top:10px;"><a href="login/logout.jsp"><input class="nextcat" type="button" value="Certified Correct and Logout System" /></a></div>
	<%}else{%>
		<div align="center" style="margin-top:10px;"><a href="process/update.jsp?judgedid=<%=Jid%>&currentStatus=<%=Jstat%>"><input class="nextcat" type="button" value="Certified Correct" /></a></div>
	<%}%>	 
<%
}catch(Exception e){
		out.print(e);
      e.printStackTrace();
}
%>  
</div>
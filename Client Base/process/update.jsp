<%@ page import="java.io.*,java.sql.*,java.net.*,java.util.*,java.text.*,java.text.SimpleDateFormat" %>
<%@ include file="../kickass/db.jsp" %>
<%

		try{

 String sqlinsert = null;
 PreparedStatement insert = null;
 int dbjCurrentStatus=0;

  String dbj=request.getParameter("judgedid");
  String stjud = "select * from tbljudges where judgeid = '"+dbj+"'"; 
	cst =  ct.executeQuery(stjud);
	while(cst.next()){
		dbjCurrentStatus= cst.getInt("status");
	}

 

if (dbjCurrentStatus==5) {
	st.executeUpdate("update tbljudges set status='1' where judgeid='"+dbj+"'");
			response.sendRedirect("../main.jsp");

}else if (dbjCurrentStatus==3) {
	st.executeUpdate("update tbljudges set status='4' where judgeid='"+dbj+"'");
			response.sendRedirect("../main.jsp");

}else if (dbjCurrentStatus==4) {
	st.executeUpdate("update tbljudges set status='1' where judgeid='"+dbj+"'");
			response.sendRedirect("../main.jsp");

}else if (dbjCurrentStatus==6) {
			response.sendRedirect("../login/logout.jsp");

}else if (dbjCurrentStatus==0) {
			response.sendRedirect("../login/logout.jsp");

}else{
		response.sendRedirect("../main.jsp");
}
			
 }catch(Exception e){
	out.print(e);
}
%>
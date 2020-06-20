<%@ page import="java.sql.*,java.util.*,java.text.*,java.text.SimpleDateFormat" %>
<%@ include file="../kickass/db.jsp"%>
<%

String urls=request.getParameter("url");

java.util.Date now = new java.util.Date();
String DATE_FORMAT = "yyyy-MM-dd hh:mm:ss";
SimpleDateFormat sdf = new SimpleDateFormat(DATE_FORMAT);
String strDateNew = sdf.format(now) ;
try
{
	st = con.createStatement();
	String queryString = "update tbllogin set outtime=current_timestamp where userid='"+ session.getAttribute("userid").toString() +"' and outtime is null";
	int i = st.executeUpdate(queryString);

	if(i>0)
	{
	st.executeUpdate("update tbljudges set status=6 where judgeid='"+session.getAttribute("userid").toString()+"'");
	session.invalidate();
	response.sendRedirect("../");
	}
	con.close();
}
catch (Exception e)
{out.print(e);
	e.printStackTrace();
}
%> 


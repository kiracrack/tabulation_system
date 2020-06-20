<%@ page import="java.io.*,java.sql.*,java.net.*,java.util.*,java.text.*,java.text.SimpleDateFormat" %>
<%@ include file="../kickass/db.jsp"%>
<%
String sqlinsert = null;
PreparedStatement insert = null;
 
  String userName = request.getParameter("user");
  String password = request.getParameter("pass");
  String none = "";
  String none2 = "";
  
  java.util.Date now = new java.util.Date();
  String DATE_FORMAT = "yyyy-MM-dd hh:mm:ss";
   SimpleDateFormat sdf = new SimpleDateFormat(DATE_FORMAT);
	  
  String strDateNew = sdf.format(now) ;
  
try {
	
	String iChars = "!@#$%^&*()+=-[]\\\';,/{}|\":<>?~"; 
   	for (int i = 0; i < userName.length(); i++) {
  	if (iChars.indexOf(userName.charAt(i)) != -1) {
  	response.sendRedirect("../index.jsp?status=invalid");
	rs.close();
  	}
  }
  for (int k = 0; k < password.length(); k++) {
  	if (iChars.indexOf(password.charAt(k)) != -1) {
  	response.sendRedirect("../index.jsp?status=invalid");
	rs.close();
  	}
  }
	
	   st = con.createStatement();
	  String strQuery = "select * from tbljudges where username='"+userName+"' and password='"+password+"' and eventid='" + GlobalEventID + "' and status<>0"; 
	  rs = st.executeQuery(strQuery);
	 
	   if(rs.next())
		{
		    userid=rs.getString("judgeid");
			user_name=rs.getString("username");
			session.setAttribute("userid",userid);
			session.setAttribute("username",user_name);
		    session.setAttribute("intime",strDateNew); 
	
	 st.executeUpdate("INSERT INTO tbllogin set userid='"+userid+"',intime=current_timestamp");
	 st.executeUpdate("UPDATE tbljudges set status=5 where judgeid='" + userid + "'");

int fi = 0;		
String QueryString=("select * from tbllogin where userid='"+userid+"'");
	rst = stmt.executeQuery(QueryString);
 	 while(rst.next()){
		fi++;}
		if(fi == 0){
		     response.sendRedirect("../main.jsp?url=getstarted");
		}else{
		     response.sendRedirect("../main.jsp");
		}
	}
        response.sendRedirect("../index.jsp?status=invalid");
        con.close();
        
    } catch (Exception e) {
		out.print(e);
      e.printStackTrace();
    }
 %> 

	
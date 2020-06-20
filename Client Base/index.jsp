<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<%@ include file="kickass/db.jsp"%>
  <%String dbiplog=request.getRemoteAddr();%>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=windows-1252" />
<title><%=GlobalEventCategory%></title>
<link rel="stylesheet" type="text/css" href="style.css" />
<link rel="icon" href="images/ico.gif" type="image/x-icon" />
</head>
<body>
<%
	String loguser="";
	String ids="";
	if(session.getAttribute("username")!=null && session.getAttribute("username")!="")
	{ 
	response.sendRedirect("main.jsp");
	}
	else
	{
	
	}
%>
<script type="text/javascript" src="js/wz_tooltip.js"></script>
<div id="main_container">

	<div id="header">
    <div class="logo" style="display:none">
    <a href="index.html"><img src="images/logo.gif" alt="" title="" border="0" /></a>
    </div>
    
    </div>
    <div>&nbsp;</div>
              
            
    <div id="main_content">
    
    	<div class="center_content">
			 <div id="menu_tab"></div> 
            
            
            
<!-- First Content Area  --> <div class="welcome_block">
            	<div style="font-family:Myriad Pro Cond;font-weight:bold; font-size:30px; padding:0px;">WELCOME TO <%=GlobalEventTitle.toUpperCase() %></div>
                             
            </div> <!-- End First Content Area  --> 
          <!-- Content Area -->  <div class="products">
            	<!--<div class="title"><img src="images/title_products.gif" alt="" title="" /></div> -->
            <div class="products_box">                                  
                <div class="clear"></div>
                		<%String dbuser=request.getParameter("user");%>
        <%String dbpass=request.getParameter("pass");%>
        <%String dbstat=request.getParameter("status");%>
        <%try{%>
          <%
		  if(dbuser!=(null) && dbpass!=(null) && dbuser!=("") && dbpass!=("") ){
			 response.sendRedirect("login/submit.jsp?user="+dbuser+"&pass="+dbpass+""); 
		  }
		  %>
          <p id="errorShortDescText_malware"><strong>Note:</strong> Three times  failed to login, your computer will be banned by administrator.
          <table><form action="index.jsp" method="post">
          <%if(dbstat.equals("invalid")){%>
          <tr><td></td><td><div align="right" style="font-size:10px; color:#C60">Invalid Username and Password</div></td></tr>
          <%}%>
          <%if(dbuser.equals("")){%>
          <tr><td>Username:</td><td><input type="hidden" name="status" value=""><input class="errForm" type="text" name="user" value=""><div align="right" style="font-size:10px; color:#C60">Please Enter username</div></td></tr>
          <%}else{%>
          <tr><td>Username:</td><td><input type="hidden" name="status" value=""><input class="sucForm" type="text" name="user" value="<%=dbuser%>" ></td></tr>
          <%}%>
          <%if(dbpass.equals("")){%>
          <tr><td>Password:</td><td><input type="hidden" name="status" value=""><input class="errForm" type="password" name="pass" value=""><div align="right" style="font-size:10px; color:#C60">Please Enter Password</div></td></tr>
          <%}else{%>
          <tr><td>Password:</td><td><input type="hidden" name="status" value=""><input class="sucForm" type="password" name="pass" value=""></td></tr>
          <%}%>
          <%}catch(Exception e){
			  %>
			  <tr><td>Username:</td><td><input type="hidden" name="status" value=""><input class="sucForm" type="text" name="user" value="" ></td></tr>
              <tr><td>Password:</td><td><input type="hidden" name="status" value=""><input class="sucForm" type="password" name="pass" value=""></td></tr>
			  <%
			}%>
            
          <tr><td ></td><td align="right"><input type="submit" name="submit" value="Login me"></td></tr>         
          </form></table>
                    
                    
                </div>
            </div>
             <!-- End Content Area -->
            <div class="clear"></div>
      </div>
            
            
  <%@ include file="template/footer.jsp"%>           
            
        </div>
           
    </div>
    


</div>
</body>
</html>
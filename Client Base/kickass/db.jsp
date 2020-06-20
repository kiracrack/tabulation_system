<%@ page import="java.io.*,java.sql.*,java.util.*,java.text.*,java.text.SimpleDateFormat" %>
<%!
public String url = "jdbc:mysql://localhost/judging";
public Connection con = null;
public Statement stmt = null;
public Statement st = null;
public Statement ct = null;

public ResultSet rs = null;
public ResultSet rst = null;
public ResultSet cst = null;

public String sqlquery = "";
 
public String userid = "";
public String user_name = "";

public String Jid = ""; 
public String JNo = ""; 
public String Jfullname =""; 
public String Jstat = "";

public String Activetopid=  "";
public String Activecatid=  "";

public String GlobalEventID=  "";
public String GlobalEventName=  "";
public String GlobalEventCategory=  "";
public String GlobalEventTitle=  "";
public String GlobalEventDate=  "";
public String GlobalContestantType=  "";
public String GlobalScoreType=  "";
public String GlobalComputation=  "";
public String GlobalSymbol=  "";
public String GlobalBatchCode=  "";

public String GlobalRankCode="";
public String GlobalRankDescription="";
public String GlobalCategoryId = "";
public String GlobalCategoryDescription = "";
public boolean GlobalCategoryLast;
public boolean GlobalWithImage;

%>
<%		
Class.forName("com.mysql.jdbc.Driver").newInstance();
Class.forName("org.gjt.mm.mysql.Driver").newInstance();
          con = DriverManager.getConnection(url, "root", "12sysadmin34");
          stmt = con.createStatement();
		  st = con.createStatement();
		  ct = con.createStatement();
		  
		 
		sqlquery = "select * from tblevent where activated=1"; 
		rst =  stmt.executeQuery(sqlquery);
		while(rst.next()){
			GlobalEventID= rst.getString("eventid");	
			GlobalEventName= rst.getString("eventName");		
			GlobalEventCategory= rst.getString("eventCategory");		
			GlobalEventTitle= rst.getString("eventTitle");		
			GlobalEventDate= rst.getString("eventDate");		
			GlobalContestantType= rst.getString("contestanttype");		
			GlobalScoreType= rst.getString("scoretype");	
			GlobalComputation= rst.getString("computation");	
			GlobalSymbol= rst.getString("symbol");
			GlobalWithImage = rst.getBoolean("withimage");
		}
		GlobalRankCode = "";
		sqlquery = "select * from tblrankingcategory where eventid='" + GlobalEventID + "' and activated=1"; 
		rst =  stmt.executeQuery(sqlquery);
		while(rst.next()){
			GlobalRankCode= rst.getString("rankid");	
			GlobalRankDescription= rst.getString("rankDescription");		 
		}
		if (GlobalRankCode==""){
			GlobalRankCode="DEFAULT";
			GlobalRankDescription= "DEFAULT";
		}

		sqlquery = "select * from tblcriteriacategory inner join tbljudgecategory on tblcriteriacategory.categoryid = tbljudgecategory.categoryid where tbljudgecategory.eventid='" + GlobalEventID + "' and rankid='" + GlobalRankCode + "' and judgeid='" + session.getAttribute("userid") + "' and activated=1"; 
		rst =  stmt.executeQuery(sqlquery);
		while(rst.next()){
			GlobalCategoryId= rst.getString("categoryid");	
			GlobalCategoryDescription= rst.getString("categoryDescription");
			GlobalCategoryLast = rst.getBoolean("lastcategory");		 
		}

		sqlquery = "select * from tblbatch where eventid='" + GlobalEventID + "' and activated=1"; 
		rst =  stmt.executeQuery(sqlquery);
		while(rst.next()){
			GlobalBatchCode= rst.getString("batchcode");	
			 	 
		}

%>
<%!public String RemovedStr(String htmlString){	
	 	htmlString = htmlString.replaceAll("qwertyuiopasdfghjklzxcvbnm", "");
	 	return htmlString;
}
%>










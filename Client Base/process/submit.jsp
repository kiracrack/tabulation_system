<%@ page import="java.io.*,java.sql.*,java.net.*,java.util.*,java.text.*,java.text.SimpleDateFormat" %>
<%@ include file="../kickass/db.jsp" %>
<%
 String sqlinsert = null;
 PreparedStatement insert = null;
 
  String subno=request.getParameter("subno");
  String contestantno=request.getParameter("contestantno");
  String contestantid=request.getParameter("contestantid");
  String judgeid=request.getParameter("judgeid");
  float s_score ;
  String judged = "";
  int jstatus = 0;
  Boolean InvalidScore = true;
  int subcount = Integer.parseInt(subno);
  
	String stjud = "select * from tbljudges where judgeid = '"+judgeid+"'"; 
	cst =  ct.executeQuery(stjud);
	while(cst.next()){
		jstatus= cst.getInt("status");
	}
	if(jstatus==2 || jstatus==3){

			/* DELETE OLD SCORE */
			st.executeUpdate("delete from tblscores where eventid='" + GlobalEventID + "' and rankid='" + GlobalRankCode + "' and categoryid='" + GlobalCategoryId + "' and judgeid='" + judgeid + "' and contestantid='" + contestantid + "'");
				
		for(int i=1; i<=subcount;i++){
			String criteriaid=request.getParameter("subid"+i);
			float fscore = 0;

			String dbscore=request.getParameter("score"+criteriaid);
			/* CHECKING VALID SCORE */
			if (dbscore=="" || dbscore.equals("0") ||  dbscore.equals("-0") || Float.parseFloat(dbscore) < 0 ){
				InvalidScore = true;
			}else{
				fscore = Float.parseFloat(dbscore);
				rs =  st.executeQuery("select * from tblcriteriaforjudging where criteriaid = '"+criteriaid+"'");
				while(rs.next()){
					if (fscore > rs.getFloat("criteriaScore")){
						InvalidScore = true;
					}else{
						InvalidScore = false;
					}
				}

				if (InvalidScore==false){
				/* INSERT NEW SCORE */
					st.executeUpdate("insert into tblscores set eventid='" + GlobalEventID + "', rankid='" + GlobalRankCode + "', categoryid='" + GlobalCategoryId + "', judgeid='" + judgeid + "', contestantid='" + contestantid + "', criteriaid= '" + criteriaid + "',score='" + fscore + "'");

					/* UPDATE JUDGE STATUS */
					st.executeUpdate("update tbljudges set status=3 where judgeid='" + judgeid + "'");
				}
			}
		}
		if (InvalidScore==true){
			response.sendRedirect("../main.jsp?status=invalid");
		}else{
			int min = Integer.parseInt(contestantno);
			String kk = new Integer(min).toString();
 			response.sendRedirect("../main.jsp?#c"+kk);
		}
		
	}else{
		response.sendRedirect("../main.jsp?status=invalid");
	}

%>
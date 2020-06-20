            <div id="menu_tab">                                     
                    <ul class="menu">                                                                               
                         <li><a <%if (urls.equals("production")){%>href="#"<%}else{%> href="#" onclick="alert('You are not allowed to access this categoory')" <%}%> class="<%if (urls.equals("production")){%>nav_selected<%}else{%>nav<%}%>"> Production </a></li>
                         <li><a <%if (urls.equals("schooluni")){%>href="#"<%}else{%> href="#" onclick="alert('You are not allowed to access this categoory')" <%}%>class="<%if (urls.equals("schooluni")){%>nav_selected<%}else{%>nav<%}%>"> School Uniform </a></li>
                         <li><a <%if (urls.equals("glamtrash")){%>href="#"<%}else{%> href="#" onclick="alert('You are not allowed to access this categoory')" <%}%> class="<%if (urls.equals("glamtrash")){%>nav_selected<%}else{%>nav<%}%>"> Glam Trash </a></li>
                         <li><a <%if (urls.equals("terno")){%>href="#"<%}else{%> href="#" onclick="alert('You are not allowed to access this categoory')" <%}%> class="<%if (urls.equals("terno")){%>nav_selected<%}else{%>nav<%}%>"> Philippine Terno </a></li>
                         <li><a <%if (urls.equals("beauty")){%>href="#"<%}else{%> href="#" onclick="alert('You are not allowed to access this categoory')" <%}%> class="<%if (urls.equals("beauty")){%>nav_selected<%}else{%>nav<%}%>"> Beauty </a></li>
              </ul>
            </div> 
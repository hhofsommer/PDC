<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PDC.aspx.vb" Inherits="PDC" %>

<!DOCTYPE html>

<head> 
<meta name="google" content="notranslate" />
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=yes">
<meta name="keywords" content="htmlcss bootstrap menu, navbar, hover nav menu CSS examples" />
<meta name="description" content="Pension Date Calculator" /> 
<meta name="author" content="Dick Hofsommer">

<title>VMS Info</title>
<link runat="server" rel="shortcut icon" href="favicon.ico" type="image/x-icon"/>
<link runat="server" rel="icon" href="favicon.ico" type="image/ico"/>

    <!-- Import bootstrap cdn -->
    <link rel="stylesheet" href= 
"https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"   integrity= 
"sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2"
        crossorigin="anonymous"> 
  
    <!-- Import jquery cdn -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" 
        integrity= 
"sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"
        crossorigin="anonymous"> 
    </script> 
      
    <script src= 
"https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js" 
        integrity= 
"sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx" 
        crossorigin="anonymous"> 
    </script> 


  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

<style>
  #panel1 {
    width:30%; 
    height:auto;
    top:300px;
    margin:0 auto;
    text-align:center;
    border :thin;
  }

.footer{
  flex: 0 0 auto;
  display: flex;
  margin: 1em;
  padding: 1em;
  width: 100%;
  justify-content: center;
}

.header{
  flex: 0 0 auto;
  display: flex;
  margin: 1em;
  padding: 1em;
  width: 100%;
  justify-content: center;
}

.blur-rule {
  height: 1px;
  width: 100%; 
  position: relative;
  background-color: #0000FF;
  margin: 20px 0;
  margin-left: -20px;
  margin-right: -20px; 
  display: block;
  
  -webkit-box-shadow: 0 0 0px 0 #0000FF;
  -moz-box-shadow: 0 0 0px 0 #0000FF;
  box-shadow: 0 0 0px 0 #0000FF;
}

* {
  box-sizing: border-box;
}

/* Create two equal columns that floats next to each other */
.column {
  float: left;
  width: 50%;
  padding: 10px;
  height: 300px; /* Should be removed. Only for demonstration */
}

/* Clear floats after the columns */
.row:after {
  content: "";
  display: table;
  clear: both;
}

.responsive {
  width: 60%;
  height: auto;
}

body {
  overflow: hidden; /* Hide scrollbars */
}

</style>  
</head> 
  
<body> 
    <form id="form1" runat="server" visible="true">
        <div class="container" style="text-align:center;margin-top :50px;">
            <img src="pensioen1.jpg" alt="Pensioen" class="responsive">

            <div class="row">
                <div class="header">
                   <H3>Pensioen Datum Calculator</H3>
                </div>
                <div class="header">
                   <H5>© All Rights Reserved - Dick Hofsommer <asp:Label ID="AppYear" runat="server" Text=""></asp:Label> - <script>document.write(new Date().getFullYear())</script></H5>
                </div>
                <div class="header">
                   <asp:Button ID="CmdNext"  runat="server" Text="Continue" />
                </div>
             </div>
        </div>
    </form>

    <form id="form2" runat="server" visible="false">
       <div>
          <asp:ScriptManager ID="ScriptManager1" runat="server" />
       </div>
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css">
        <div class="container">
                <div class="panel panel-default" style="border: medium solid #000000">
                        <div> <asp:Label ID="Label11" runat="server" Text="Pensioen Datum Calculator" Font-Bold="True" Font-Size="X-Large" style="margin-left:15px" >  </asp:Label>
                </div>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>              
                        <div class="form-group row"> 
                            <label for="description" >
                                <asp:Label ID="Label12" runat="server" Text="Geboorte datum" Font-Bold="True" Font-Size="Smaller" style="margin-left:30px"></asp:Label>
                            </label> 
                            <div class="col-6"> 
                                <asp:TextBox ID="Veld1" runat="server" Visible="true" style="margin-left:50px;" TextMode="Date" BackColor="#FFFFCC"></asp:TextBox>
                            </div> 
                        </div>
                        
                        <div class="form-group row"> 
                            <label for="description" >
                                <asp:Label ID="Label13" runat="server" Text="Uren werkweek" Font-Bold="True" Font-Size="Smaller" style="margin-left:30px"></asp:Label>
                            </label> 

                                <div class="col-6"> 
                                    <asp:TextBox ID="Veld2" runat="server"  Visible="True" style="margin-left:55px;" Width="30" BackColor="#FFFFCC"></asp:TextBox>
                            </div> 
                        </div> 

                        <div class="form-group row"> 
                            <label for="description" >
                                <asp:Label ID="Label14" runat="server" Text="Extra vrije dagen" Font-Bold="True" Font-Size="Smaller" style="margin-left:30px"></asp:Label>
                            </label> 

                                <div class="col-6"> 
                                    <asp:TextBox ID="Veld3" runat="server"  Visible="True" style="margin-left:45px;" Width="30" BackColor="#FFFFCC"></asp:TextBox>
                            </div> 
                        </div> 

                        <div class="row">
                            <div  class="col-6-lg"> 
                                <asp:Label ID="Label1" runat="server" style="margin-left:30px" Text="Leeftijd :"> </asp:Label>
                                <asp:Label ID="Label2" runat="server" style="margin-left:10px" Text="Pensioen datum :"></asp:Label> <asp:Label ID="Label10" runat="server" style="margin-left:10px" Text="*" Visible ="False" Font-Bold="True"></asp:Label><asp:Label ID="Label5" runat="server" style="margin-left:10px" Visible ="false" Font-Bold="True"></asp:Label>
                            </div>
                        </div>

                        <div class="row">
                            <div  class="col-4-lg"> 
                                <asp:Label ID="Label17" runat="server" Text="_____________________________________________________________" Font-Bold="True" Font-Size="Smaller" style="margin-left:30px"></asp:Label>
                            </div>
                        </div>

                        <div class="form-group row"> 
                            <label for="description"> 
                                <asp:Label ID="Label15" runat="server" Text="Nog te werken" Font-Bold="True" Font-Size="Smaller" style="margin-left:30px"></asp:Label>
                            </label> 
                        </div> 

                        <div class="row">
                                 <asp:Label ID="Label6" runat="server" style="margin-left:30px"  Text="Dagen :"></asp:Label>
                                <asp:Label ID="Label7" runat="server" style="margin-left:10px" Text="Weken :"></asp:Label>
                                <asp:Label ID="Label8" runat="server" style="margin-left:10px" Text="Maanden :"></asp:Label>
                                <asp:Label ID="Label9" runat="server" style="margin-left:10px" Text="Jaren :"></asp:Label>
                        </div>

                        <br>

                        <div class="row">
                            <div  class="col-4-lg"> 
                                <asp:Label ID="Label3" runat="server" style="margin-left:30px" Text="Vakantie uren / dagen op basis van uren werkweek :"></asp:Label>
                            </div>
                        </div>

                        <div class="row">
                            <div  class="col-4-lg"> 
                                <asp:CheckBox ID="CB1" runat="server" style="margin-left:30px" ToolTip="Vakantie dagen verrekenen met nog te werken dagen." Visible="False" AutoPostBack="True" /> <asp:Label ID="Label4" runat="server" style="margin-left:15px" Text="Vakantie berekenen" Visible ="false" ></asp:Label>
                            </div>
                        </div>

                        <br>
                        <br>
 
                        <div
                            class="form-group row"> 
                            <asp:Button ID="CmdRefresh" runat="server" style="margin-left:30px" Text="Refresh" Width="90" ToolTip="Maak invoervelden weer leeg." BackColor="#66CCFF" BorderColor="#66CCFF" />
                            <asp:Button ID="CmdReken" runat="server" style="margin-left:25px" Text="Bereken" Width="90" ToolTip="Maak berekening met ingevoerde gegevens." BackColor="#66CCFF" BorderColor="#66CCFF" />
                            <asp:Button ID="CmdSet" runat="server" style="margin-left:25px" Text="Settings" Width="90" ToolTip="Instellingen voor de berekening." Enabled="true" BackColor="#66CCFF" BorderColor="#66CCFF"  />
                        </div>

                        <br>
                        <div class="row">
                            <div>
                                <asp:Button ID="CmdError" runat="server" Text="Button" style="margin-left:30px" Visible ="false" BorderColor="#FF3300" ForeColor="White" BackColor="#FF3300" ToolTip="Click op melding om door te gaan!" />
                                <br>                        
                            </div>
                        </div>
                        <div class="row">
                            <div>
                                <asp:Label ID="Label16" runat="server" Text="Label" Visible="False"></asp:Label>
                                <br>                        
                            </div>
                        </div>
                      </ContentTemplate>
                   </asp:UpdatePanel>
               </div>
           </div>
     </form>

    <form id="form3" runat="server" visible="false">
       <div class="container">
                <div class="panel panel-default" style="border: medium solid #000000">
                        <div> <asp:Label ID="Label18" runat="server" Text="Instellingen pensioen datum berekening." Font-Bold="True" Font-Size="Larger" style="margin-left:15px" >  </asp:Label>
                </div>

                <br />

                <div class="container-fluid">
                    <div class="row" style="background-color:aquamarine  ">
                      <div class="col-xs" style="margin-left:15px">Geboren t/m</div>
                      <div class="col-xs" style="margin-left:25px" >AOW-leeftijd</div>
                      <div class="col-xs" style="margin-left:25px">en maanden</div>
                      <div class="col-xs" style="margin-left:25px">Staat vast</div>
                    </div>
                    <div class="row" style="margin-left:0px">
                      <div class="col-xs" style="margin-left:3px" >31-08-1955</div>
                      <div class="col-xs" style="margin-left:60px">66</div>
                      <div class="col-xs" style="margin-left:90px">4</div>
                      <div class="col-xs" style="margin-left:83px">Ja</div>
                    </div>
                    <div class="row" style="background-color: aliceblue ">
                      <div class="col-xs" style="margin-left:18px" >31-05-1956</div>
                      <div class="col-xs" style="margin-left:60px">66</div>
                      <div class="col-xs" style="margin-left:90px">7</div>
                      <div class="col-xs" style="margin-left:83px">Ja</div>
                    </div>
                    <div class="row" style="margin-left:0px">
                      <div class="col-xs" style="margin-left:3px" >28-02-1957</div>
                      <div class="col-xs" style="margin-left:60px">66</div>
                      <div class="col-xs" style="margin-left:86px">10</div>
                      <div class="col-xs" style="margin-left:79px">Ja</div>
                    </div>
                    <div class="row" style="background-color: aliceblue ">
                      <div class="col-xs" style="margin-left:18px" >31-12-1960</div>
                      <div class="col-xs" style="margin-left:60px">67</div>
                      <div class="col-xs" style="margin-left:90px">0</div>
                      <div class="col-xs" style="margin-left:83px">Ja</div>
                    </div>
                    <div class="row" style="margin-left:0px">
                      <div class="col-xs" style="margin-left:3px" >30-09-1961</div>
                      <div class="col-xs" style="margin-left:60px">67</div>
                      <div class="col-xs" style="margin-left:90px">3</div>
                      <div class="col-xs" style="margin-left:83px">Ja</div>
                    </div>
                    <div class="row" style="background-color: aliceblue ">
                      <div class="col-xs" style="margin-left:18px" >30-09-1963</div>
                      <div class="col-xs" style="margin-left:60px">67</div>
                      <div class="col-xs" style="margin-left:90px">3</div>
                      <div class="col-xs" style="margin-left:80px">Nee</div>
                    </div>
                    <div class="row" style="margin-left:0px">
                      <div class="col-xs" style="margin-left:3px" >30-06-1967</div>
                      <div class="col-xs" style="margin-left:60px">67</div>
                      <div class="col-xs" style="margin-left:90px">6</div>
                      <div class="col-xs" style="margin-left:80px">Nee</div>
                    </div>
                    <div class="row" style="background-color: aliceblue ">
                      <div class="col-xs" style="margin-left:18px" >31-03-1970</div>
                      <div class="col-xs" style="margin-left:60px">67</div>
                      <div class="col-xs" style="margin-left:90px">9</div>
                      <div class="col-xs" style="margin-left:80px">Nee</div>
                    </div>
                    <div class="row" style="margin-left:0px">
                      <div class="col-xs" style="margin-left:3px" >31-12-1972</div>
                      <div class="col-xs" style="margin-left:60px">68</div>
                      <div class="col-xs" style="margin-left:90px">0</div>
                      <div class="col-xs" style="margin-left:80px">Nee</div>
                    </div>
                    <div class="row" style="background-color: aliceblue ">
                      <div class="col-xs" style="margin-left:18px" >30-09-1976</div>
                      <div class="col-xs" style="margin-left:60px">68</div>
                      <div class="col-xs" style="margin-left:90px">3</div>
                      <div class="col-xs" style="margin-left:80px">Nee</div>
                    </div>
                    <div class="row" style="margin-left:0px">
                      <div class="col-xs" style="margin-left:3px" >30-06-1979</div>
                      <div class="col-xs" style="margin-left:60px">68</div>
                      <div class="col-xs" style="margin-left:90px">6</div>
                      <div class="col-xs" style="margin-left:80px">Nee</div>
                    </div>
                    <div class="row" style="background-color: aliceblue ">
                      <div class="col-xs" style="margin-left:18px" >31-03-1982</div>
                      <div class="col-xs" style="margin-left:60px">68</div>
                      <div class="col-xs" style="margin-left:90px">9</div>
                      <div class="col-xs" style="margin-left:80px">Nee</div>
                    </div>
                    <div class="row" style="margin-left:0px">
                      <div class="col-xs" style="margin-left:3px" >31-12-1985</div>
                      <div class="col-xs" style="margin-left:60px">69</div>
                      <div class="col-xs" style="margin-left:90px">0</div>
                      <div class="col-xs" style="margin-left:80px">Nee</div>
                    </div>
                    <div class="row" style="background-color: aliceblue ">
                      <div class="col-xs" style="margin-left:18px" >30-09-1989</div>
                      <div class="col-xs" style="margin-left:60px">69</div>
                      <div class="col-xs" style="margin-left:90px">3</div>
                      <div class="col-xs" style="margin-left:80px">Nee</div>
                    </div>
                    <div class="row" style="margin-left:0px">
                      <div class="col-xs" style="margin-left:3px" >30-06-1993</div>
                      <div class="col-xs" style="margin-left:60px">69</div>
                      <div class="col-xs" style="margin-left:90px">6</div>
                      <div class="col-xs" style="margin-left:80px">Nee</div>
                    </div>
                    <div class="row" style="background-color: aliceblue ">
                      <div class="col-xs" style="margin-left:18px" >31-03-1997</div>
                      <div class="col-xs" style="margin-left:60px">69</div>
                      <div class="col-xs" style="margin-left:90px">9</div>
                      <div class="col-xs" style="margin-left:80px">Nee</div>
                    </div>
                    <div class="row" style="margin-left:0px">
                      <div class="col-xs" style="margin-left:3px" >31-12-2000</div>
                      <div class="col-xs" style="margin-left:60px">70</div>
                      <div class="col-xs" style="margin-left:90px">3</div>
                      <div class="col-xs" style="margin-left:80px">Nee</div>
                    </div>
                    <br>
                    <asp:Label ID="Label20" runat="server" Text="Vakantie uren zijn gebaseerd op 25 dagen à 8 uur bij een 40-urige" Visible="true"></asp:Label>
                    <asp:Label ID="Label21" runat="server" Text="werkweek. Meer dagen voer die in bij extra vrije dagen." Visible="true"></asp:Label>
                </div>
                
                <br />

                <div class="container-fluid">
                    <asp:Button ID="CmdRetour"  runat="server" Text="Retour" Width="90" ToolTip="Terug naar berekening." Enabled="true" BackColor="#66CCFF" BorderColor="#66CCFF" />
                 </div>
            
                 <div class="row">
                    <div>
                        <asp:Label ID="Label19" runat="server" Text="Label" Visible="false"></asp:Label>
                        <br>                        
                    </div>
                </div>               
            </div>
        </div>
    </form>
</body> 




<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebPizza.aspx.cs" Inherits="prjWebCsIntroductionAsp.Net_Reprise_2_.WebPizza" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
    <title></title>
    <style type="text/css">
        .premiertitre {
            text-align: center;
            color: #CC0000;
            font-family: "Arial Rounded MT Bold";
        }
       
      
        .marquee {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            color: white;
            background-color: red;
        }
       
        td {
            /*border:1px solid black;*/
        }

         .pantitre {
            text-align: center;
            color:black;
            font-family: "Arial Rounded MT Bold";
        }
           .entete {
            text-align: right;
            color:black;
            font-family: "Arial Rounded MT Bold";
        }

           #lstTaillePizza{
               height:65px;
           }
       
    </style>
</head>



<body style="height: 205px">
    <form id="form1" runat="server">

        <div class="auto-style1">
            <h1 class="premiertitre">TECCART PIZZA HURTS</h1>
        </div>

        <hr />
        <div class="divmarquee">
            <marquee class="marquee">
                Commander les meilleures pizzas du monde avec des ingredients extraordinaires 
        comme du bacon halal, peperoni kacher, biere halal et du fromage de cochon
            </marquee>
        </div>
        <hr />


        <table class="auto-style1">

            <tr>
                <td rowspan="2" style="vertical-align:top">
                    <asp:Panel ID="panPizza" runat="server" Font-Bold="True"  CssClass="pantitre"      GroupingText="Informations sur la Pizza" BackColor="#FFCCCC">
                    <table>
                          <tr>
                            <td class="entete">Téléphone</td>
                            <td>
                                <asp:TextBox ID="txtTelephone" runat="server"></asp:TextBox>
                              </td>
                         </tr>

                         <tr>
                            <td class="entete">Nom Complet</td>
                            <td>
                                <asp:TextBox ID="txtNomComplet" runat="server"></asp:TextBox>
                             </td>
                         </tr>

                         <tr>
                            <td class="entete">Pour livraison</td>
                            <td>                                
                                <asp:CheckBox ID="chkLivraison" runat="server" AutoPostBack="True" OnCheckedChanged="chkLivraison_CheckedChanged" />
                                
                             </td>
                         </tr>
                         <tr>
                            <td class="entete">
                                <asp:Label ID="lblAdresseLivraison" runat="server" Text="Adresse le livraison"></asp:Label>
                             </td>
                            <td>                                
                                <asp:TextBox ID="txtAdresseLivraison" runat="server" TextMode="MultiLine"></asp:TextBox>
                                
                             </td>
                         </tr>



                          <tr>
                            <td class="entete">Choisir Pizza</td>
                            <td>
                                <asp:DropDownList ID="lstPizza" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lstPizza_SelectedIndexChanged"></asp:DropDownList>
                                
                             </td>
                         </tr>
                          <tr>
                            <td class="entete">Choisir Taille</td>
                            <td>
                                
                                <asp:ListBox ID="lstTaillePizza" runat="server" AutoPostBack="True"></asp:ListBox>
                                
                             </td>
                         </tr>
                         <tr>
                            <td class="entete">Choisir Garniture</td>
                            <td style="text-align:left">
                                
                                <asp:CheckBoxList ID="lstChkGarnitures" runat="server" AutoPostBack="True"></asp:CheckBoxList>
                                
                             </td>
                         </tr>
                         <tr>
                            <td class="entete">Choisir Croute</td>
                            <td style="text-align:left">
                                <asp:RadioButtonList ID="lstRadCroute" runat="server"></asp:RadioButtonList>                                
                             </td>
                         </tr>


                    </table>
                </asp:Panel>
               
              </td>
                <td style="vertical-align:top">

                    <asp:Panel ID="panPrix" CssClass="pantitre" runat="server" Font-Bold="True" GroupingText="Informations sur le prix" BackColor="#FFCCCC">
                        <asp:Literal ID="litPrix" runat="server">
                           
                            

                        </asp:Literal>
                        <hr />
                        <asp:Button ID="btnCommande" runat="server" Text="Commandez " OnClick="btnCommande_Click" />
                    </asp:Panel>
                </td>
                
            </tr>
            <tr>
               
                <td style="vertical-align:top">
                    <asp:Panel ID="panCommande" CssClass="pantitre" runat="server"  Font-Bold="True" GroupingText="Informations sur la commande" BackColor="#FFCCCC">
                        <asp:Literal ID="litCommande" runat="server"></asp:Literal>
                    </asp:Panel>
                </td>
               
               
            </tr>
            <tr>
                
                <td>&nbsp;</td>
                <td>&nbsp;</td>
               
            </tr>
            <tr>
               
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                
            </tr>
            <tr>
              
                <td>&nbsp;</td>
                <td>&nbsp;</td>
               
            </tr>
            <tr>
               
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                
            </tr>
             <tr>
               
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                
            </tr>
             <tr>
               
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                
            </tr>
         
            
        </table>


    </form>
</body>
</html>

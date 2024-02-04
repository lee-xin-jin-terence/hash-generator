<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HashGeneratorApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1 class="mb-5">Online Hash Function By Terence Lee
    </h1>


    <!-- Dropdown list for user to select hash algorithm -->

    <div class="mt-4 mb-2 drop-down-container ">

         <label class="fw-bold">Select Hash Algorithm To Use:</label>
        
        <asp:DropDownList  ID="hashAlgorithmDropDownList" runat="server"
            OnSelectedIndexChanged="hashAlgorithmDropDownList_SelectedIndexChanged"
            AutoPostBack="True"  CssClass="drop-down-list">
            <asp:ListItem Value="MD5">MD5</asp:ListItem>
            <asp:ListItem Value="SHA1">SHA1</asp:ListItem>
            <asp:ListItem Value="SHA256">SHA256</asp:ListItem>
            <asp:ListItem Value="SHA384">SHA384</asp:ListItem>
            <asp:ListItem Value="SHA512">SHA512</asp:ListItem>
        </asp:DropDownList>
    </div>
    

    
    <div class="grid-container mt-4">
         
        <!-- Textbox for user to enter hash input -->

        <div  class="hash-input-container">
            <label class="d-block fw-bold" >Enter Your Text Below:</label> 
            <asp:TextBox ID="hashInputTextBox" runat="server" TextMode="MultiLine" 
                 CssClass="hash-input-textbox"   Rows="8" ></asp:TextBox>
        </div> 


        <!-- Contains the arrow image and generate hash button -->

        <div class="arrow-and-button-container">
                   
            <asp:Image             
                runat="server"
                ImageUrl="~/assets/images/right-arrow.png"
                      
                CssClass="arrow-image" />

            <asp:Button CssClass="btn btn-primary generate-button" ID="generateHashButton" 
                runat="server" Text="Generate MD5 Hash" OnClick="generateHashButton_Click"
                />
          
        </div>

        <!-- Textbox for display of hash output -->
        
        <div class="hash-output-container">
            
            <label class="fw-bold">Your Hash Output:</label>
   
            <asp:TextBox ID="hashOutputTextBox" runat="server" TextMode="MultiLine" 
                ReadOnly="True" CssClass="hash-output-textbox"
                  Rows="8"></asp:TextBox>

        </div>
           
    </div>
    
    
</asp:Content>

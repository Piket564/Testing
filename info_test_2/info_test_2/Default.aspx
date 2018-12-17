<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="info_test_2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h4>Esercizio 1</h4>
        <p class="lead">Testing Informatica</p>
        
        <!--
            Basics - Get Departure/Arrivals of an Airport (JFK)
            Basics - Get Full name from IATA/ICAO JFK for Example
            Basics - Get flight departures from airport name (JFK)
            Basics - Get flight arrival from airport name (JFK)
            Advance- Use 2 airport (ATL - ORD) and airline to get flight (RT)            
            -->
        <ul>
            <li>
                Basics - Get Departure/Arrivals of an Airport (JFK) <asp:Button ID="btn1" runat="server" Text="test" Height="21px" Width="48px" OnClick="btn1_Click" />
            </li>
            <li>
                Basics - Get Full name from IATA/ICAO JFK for Example <asp:Button ID="btn2" runat="server" Text="test" Height="21px" Width="48px" OnClick="btn2_Click" />
            </li>
            <li>
                Basics - Get flight departures from airport name (JFK) <asp:Button ID="btn3" runat="server" Text="test" Height="21px" Width="48px" OnClick="btn3_Click" />
            </li>
            <li>
                 Advance- Use 2 airport (ATL - ORD) and airline to get flight (RT) <asp:Button ID="btn4" runat="server" Text="test" Height="21px" Width="48px" OnClick="btn4_Click" />
            </li>
        </ul>
        <br />
        <hr style="border: 2px solid black" />
        <h4>Results:</h4>
        <br />
        <!--<table id="tbl" class="display" width="100%"></table>-->
        <textarea runat="server" id="results" style="width:900px;height:900px;max-width:980px;" ></textarea>
        
    </div>
    <script>
function LoadCurrentReport(oResults) {
 
    var oTblReport = $("#tbl")
    oTblReport.DataTable ({
        "data" : items,
        "columns" : [
            { "data" : "patientId" },
            { "data" : "otherId" },
            { "data" : "firstName" },
            { "data" : "lastName" },
            { "data" : "gender" },
            { "data" : "dob" },
            { "data" : "race" }
        ]
    });
}
    </script>
</asp:Content>

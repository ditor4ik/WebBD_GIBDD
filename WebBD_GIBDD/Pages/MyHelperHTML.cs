using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;

namespace HtmlHelpersApp.App_Code
{
    public static class ListHelper
    {
        /*
        public static HtmlString CreateList(this IHtmlHelper html, string AspFor, string NameInput, Dictionary<long, string> List, string ListName, string IdInp, string placeholder, string CurValue = null)
        {
            string result = "";
            result += $"<input asp-for=\"{AspFor}\" hidden class=\"form-control {NameInput}\"/>";
            result += "<div class=\"btn-group dropright\">";
            result += "<button class=\"btn btn-primary\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">Выбрать</button>";
            result += "<div class=\"dropdown-menu\">";
            result += $"<input type=\"text\" id=\"{IdInp}\" onkeyup=\"myFunction('#{IdInp}', '{ListName}')\" class=\"form-control\" placeholder=\"{placeholder}\">";
            result += $"<ul id=\"{ListName}\">";
            foreach(KeyValuePair<long, string> item in List)
            {
                result += $"<li class=\"dropdown-item\" onclick=\"AutoInput('{item.Key}', '{NameInput}', '{item.Value}')\">{item.Value}</li> ";
            }
            result += "</ul></div></div>";
            string Value = " ";
            if (CurValue != null) Value = CurValue;
            result += $"<p class=\"{NameInput}\">{Value}</p>";
            result += $"<span asp-validation-for=\"{AspFor}\" class=\"text-danger\"></span>";
            //result += $"<!--{result}-->";
            return new HtmlString(result);
        }*/
    }
}

/*
<input asp-for="Auto.DriverID" hidden class="form-control DriverInp" />
<div class="btn-group dropright">
    <button class="btn btn-primary" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
        Выбрать
    </button>
    <div class="dropdown-menu">
        <input type="text" id="InputDriver" onkeyup="myFunction('#InputDriver', 'DriverList')" class="form-control" placeholder="Введите водителя...">
        <ul id="DriverList">
            @foreach (var item in Model.Driver)
            {
                <li class="dropdown-item" onclick="AutoInput('@item.ID','DriverInp','@Html.DisplayFor(modelitem => item.FullName)')">
                    @item.FullName
                </li>
            }
        </ul>
    </div>
</div>
<p class="DriverInp">
    выбран -
    @{
        try
        {
            @Model.Driver.First(d => d.ID == Model.Auto.DriverID).FullName
        }
        catch
        {
        <p>никто</p>
    }
    }
    </p>
    <span asp-validation-for="Auto.DriverID" class="text-danger"></span>
 */
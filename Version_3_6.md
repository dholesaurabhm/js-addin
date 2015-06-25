# Version 3.6 #
## Improvements ##
  * Enhanced support of Asp.Net <% %> markup in javascript. This blocks will be processed at parsing time via regular expressions and replaced to correct javascript string literals.
  * Added simple fix for Razor syntax in `*.cshtml files`. "@" symbol will be removed from code at parsing time. This will allow to remove unwanted javascript errors in constructions like this:
```
var model = @Html.Raw(JsonConvert.SerializeObject(Model));
```
  * Support of VS2010 and VS2012 color themes. [Read more about Visual studio themes support](VisualStudioThemesSupport.md).
  * Improved search engine, now it works more like VS autocomplete.
  * Errors notification popup bar in VS2010 and VS2012. This bar will appear automatically if JSParser find any errors in file. This bar will appear even if JSParser tool window is not opened.
> ![https://bytebucket.org/megaboich/jsparser/wiki/images/error_bar.png](https://bytebucket.org/megaboich/jsparser/wiki/images/error_bar.png)


## Bug fixes ##
  * Fixed issue with `<script></script>` blocks in js files. Introduced new setting that will disable processing of `<script></script>` blocks in js files.
  * Fixed wrong parsing of `<script type='non-javascript'>` blocks. This blocks will be ignored.
```
<script type="text/html-template" id="template1">
    <div class="container" style="position:relative;">
       ...
    </div>
</script>
```
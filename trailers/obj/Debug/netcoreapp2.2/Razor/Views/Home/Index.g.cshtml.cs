#pragma checksum "/home/branquinho/Desktop/dotnet/trailers/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "319e38002446603929b03906088b3337e65edb47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/branquinho/Desktop/dotnet/trailers/Views/_ViewImports.cshtml"
using trailers;

#line default
#line hidden
#line 2 "/home/branquinho/Desktop/dotnet/trailers/Views/_ViewImports.cshtml"
using trailers.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"319e38002446603929b03906088b3337e65edb47", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bf509075e86b6b90c493a129e04109886135995", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "/home/branquinho/Desktop/dotnet/trailers/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(46, 1116, true);
            WriteLiteral(@"    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
    <!------ Include the above in your HEAD tag ---------->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.5.0/css/all.css"" integrity=""sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU"" crossorigin=""anonymous"">
    <link href=""//netdna.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//netdna.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js""></script>
    <script src=""//code.jquery.com/jq");
            WriteLiteral("uery-1.11.1.min.js\"></script>\r\n    <!------ Include the above in your HEAD tag ---------->\r\n");
            EndContext();
            BeginContext(1165, 1837, true);
            WriteLiteral(@"
    
<div class=""container h-100""  >
    <div class=""d-flex justify-content-center h-100"">
    <div class=""searchbar"" style=""margin-top: 100px"" >
        <input id=""input_trailer"" action=""/Home/Trailer"" class=""search_input"" type=""text"" name=""movie-name"" placeholder=""Search movie trailer..."" autocomplete=""off"">
        <a href=""#"" class=""search_icon""><i class=""fas fa-search""></i></a>
    </div>
    </div>
</div>
<br>
<br>
<link href=""//netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.min.css"" rel=""stylesheet"">
<div id=""bigger_div""class=""container"" style=""display: none"">
	<div class=""row"">
		<div class=""col-md-offset-2 col-md-8 col-lg-offset-3 col-lg-6"">
    	 <div class=""well profile"" style=""width: 1200px; margin-left: -350px;"">
            <div class=""col-sm-12"">
                <div class=""col-xs-12 col-sm-4"">
                    <h2 id=""moviename"""">Nicole Pearson</h2>
                    <img id=""movieposter"" src=""smiley.gif"" alt=""Poster"" width=""200""> 
                    <p");
            WriteLiteral(@"  id=""movietype"" ><strong>About: </strong> </p>
                    <p  id=""movieyear"" ><strong>About: </strong> </p>
                    <p  id=""movieplot"" ><strong>Hobbies: </strong> </p>
                </div>             
                <div class=""col-xs-12 col-sm-8 text-center"">
                    <figure>
                        <br>
                        <br>
                        <br>
                        <div id=""player"" style=""display: none;""></div>

                    </figure>
                </div>
            </div>            
    	 </div>                 
		</div>
	</div>
</div>

<!-- <iframe id=""if"" width=""560"" height=""315"" src=""https://www.youtube.com/watch?v=fOtufaHVzfM"" frameborder=""0"" allow=""autoplay; encrypted-media"" allowfullscreen></iframe>-->


");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3020, 3697, true);
                WriteLiteral(@"



    <script src=""jquery-3.4.1.min.js""></script>

    <script>
      // 2. This code loads the IFrame Player API code asynchronously.
      var tag = document.createElement('script');

      tag.src = ""https://www.youtube.com/iframe_api"";
      var firstScriptTag = document.getElementsByTagName('script')[0];
      firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);

      // 3. This function creates an <iframe> (and YouTube player)
      //    after the API code downloads.
      var player;
      function onYouTubeIframeAPIReady() {
        player = new YT.Player('player', {
          height: '390',
          width: '640',
          videoId: 'M7lc1UVf-VE',
          events: {
            'onReady': onPlayerReady,
            'onStateChange': onPlayerStateChange
          }
        });
      }


      // 4. The API will call this function when the video player is ready.
      function onPlayerReady(event) {
        event.target.playVideo();
      }

      // 5. Th");
                WriteLiteral(@"e API calls this function when the player's state changes.
      //    The function indicates that when playing a video (state=1),
      //    the player should play for six seconds and then stop.
      var done = false;
      function onPlayerStateChange(event) {
        if (event.data == YT.PlayerState.PLAYING && !done) {
          setTimeout(stopVideo, 6000);
          done = true;
        }
      }
      function stopVideo() {
        player.stopVideo();
      }
    </script>



    <script>

    function wait(ms) {
        var start = Date.now(),
            now = start;
        while (now - start < ms) {
        now = Date.now();
        }
    }


    var first_run = true;

    $('#input_trailer').on('keypress',function(e) {
        if(e.which == 13) {
            e.preventDefault();
            $.ajax({
                url : $(this).attr('action') || window.location.pathname,
                type: ""POST"",
                data: $(this).serialize(),
                su");
                WriteLiteral(@"ccess: function (data) {
                    console.log(data);
                    data = $.parseJSON(data);

                    $(""#moviename"").html(data[""Title""]);
                    $(""#movieyear"").html(""<strong>Year: </strong>"" + data[""Year""]);
                    $(""#movieplot"").html(""<strong>Plot: </strong>"" + data[""Plot""]);
                    $(""#movietype"").html(""<strong>Type: </strong>"" + data[""Type""]);
                    $(""#movieposter"").attr(""src"", data[""Poster""]);

                    if(first_run){
                        wait(500);
                        $(""#player"").css(""display"", ""initial"");
                    }

                    if(data[""Url""]!=""error"")    player.loadVideoById(data[""Url""]);
                    else{
                        $(""#player"").css(""display"", ""none"");
                        alert(""Could not find the video on youtube"");
                        first_run=true;
                    }
                    

                    $(""#bigger_d");
                WriteLiteral(@"iv"").css(""display"", ""initial"");



                    //document.getElementById('if').src = ""https://www.youtube.com/watch?v="" + ;
                    //$('#if')[0].contentWindow.location.reload(true);
                    //document.getElementById('if').contentWindow.location.reload(true);
                    // document.getElementById('if').src = document.getElementById('if').src;
                },
                error: function (jXHR, textStatus, errorThrown) {
                    alert(""An error occured. Check the spelling"")
                }
            });
        }

    });

    </script>

");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

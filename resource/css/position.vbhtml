
<style>
    .position {
        background: url(sss.png);
    }
</style>

<div class="panel panel-primary">
            <div class="panel-heading ">
              <h3 class="panel-title">position</h3>
            </div>
            <div class="panel-body">
  <div>
     "position" property defines how the element is planted in the page. It defines like whether its position is constant in the page etc <br />
      it can have values like fixed,static,absolute,initial,relative etc.<br />
      i'm not using the value "fixed" because it paces element in a constant position in window you can test in your own
      
       <br /><br />
      EX:-<br />
          <div>
          <pre>
             <b style="color:black;font-size:12pt;"> "absolute" places element fixed in the page not in the window<br /> so the elements down will be collied with this as you can see below </b>
         
          code:&lt;div style="border:dashed;background:blue;height:115px;width:45px;position:absolute""&gt;&lt;div&gt;<br /> 
          output:<div style="border:dashed;background:blue;height:115px;width:45px;position:absolute"></div>
          code:&lt;div style="border:double;background:blue;height:45px;width:225px;position:relative"&gt;&lt;div&gt;<br /> 
          output:<div style="border:double;height:45px;background:blue;width:225px;position:relative"></div>
          code:&lt;div style="border:solid;height:75px;background:blue;width:55px;position:static"&gt;&lt;div&gt;<br /> 
          output:<div style="border:solid;height:75px;background:blue;width:55px;position:static"></div>

              
        </pre>
        </div>
  </div></div></div>
<div >
   
    <ul class="pager">
    <li class="previous"><a   style="float:left;"   href="@Href("~/pages/margin")" id="prev" >previous</a></li>
    <li class="next"><a   style="float:right;"  href="@Href("~/pages/zindex")" id="next">Next</a></li>
        </ul>
    <br /><br />
</div>
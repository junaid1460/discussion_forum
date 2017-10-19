

<div class="panel panel-primary">
            <div class="panel-heading ">
              <h3 class="panel-title">visibility</h3>
            </div>
            <div class="panel-body">
  <div>
     "visiblity" property is used to either hide or show the correspondind element<br />
      its value either visible or hidden<br />
       <br /><br />
      EX:-<br />
          <div>
          <p>
1 and 2 are visible
          code:&lt;div style="border:dashed;background:blue;height:115px;width:45px;z-index:100;position:absolute;"&gt;&lt;div&gt;<br /> 
               &lt;div style="border:double;background:blue;height:45px;width:225px;z-index:0;"&gt;&lt;div&gt;<br /> 
          <div style="border:dashed;background:blue;height:115px;width:45px;z-index:100;position:absolute;"></div>
       
          <div style="border:double;height:45px;background:blue;width:225px;z-index:0;"></div>


              <div style="margin-top:5em"></div>





          1st visible 2nd hidden     
                   code:&lt;div style="border:dashed;background:blue;height:115px;width:45px;z-index:0;
              position:absolute;"&gt;&lt;div&gt;<br /> 
                   &lt;div style="border:double;background:blue;height:45px;width:225px;z-index:1000;
              position:absolute;visibility:hidden"&gt;&lt;div&gt;<br /> 
                 <div style="border:dashed;background:blue;height:115px;width:45px;z-index:0;position:absolute;"></div>
       
                 <div style="border:double;height:45px;background:blue;width:225px;z-index:1000;position:absolute;visibility:hidden"></div>    
       
              




              
              <div style="margin-top:5em;padding:46px"></div>
              2nd visble 1st hidden
                       code:&lt;div style="border:dashed;background:blue;height:115px;width:45px;z-index:0;position:absolute;
              visibility:hidden"&gt;&lt;div&gt;<br /> 
                       &lt;div style="border:double;background:blue;height:45px;width:225px;z-index:1000;
              position:absolute"&gt;&lt;div&gt;<br /> 
          <div style="border:dashed;background:blue;height:115px;width:45px;z-index:0;position:absolute;visibility:hidden"></div>
       
          <div style="border:double;height:45px;background:blue;width:225px;z-index:1000;position:absolute"></div> 
        </p>
              <div style="margin-top:5em"></div>
        </div>
  </div></div></div>
<div>
 
    <ul class="pager">
    <li class="previous"><a   style="float:left;"   href="@Href("~/pages/zindex")" id="prev" >previous</a></li>
    <li class="next"><a   style="float:right;"  href="@Href("~/pages/float")" id="next">Next</a></li>
        </ul>
    <br /><br />
</div>
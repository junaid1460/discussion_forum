

<div class="panel panel-primary">
            <div class="panel-heading ">
              <h3 class="panel-title">z-index</h3>
            </div>
            <div class="panel-body">
  <div>
     "z-index" means the geometrical z axis, it is not actually z axis as in the other languges the function like bring
      to front,move back the z-index moves the element back or front.<br />
      It accepts any numbers as its value.
      
       <br /><br />
      EX:-<br />
          <div>
          <p>
1 over 2
          code:&lt;div style="border:dashed;background:blue;height:115px;width:45px;z-index:100;position:absolute;"&gt;&lt;div&gt;<br /> 
               &lt;div style="border:double;background:blue;height:45px;width:225px;z-index:0;"&gt;&lt;div&gt;<br /> 
          <div style="border:dashed;background:blue;height:115px;width:45px;z-index:100;position:absolute;"></div>
       
          <div style="border:double;height:45px;background:blue;width:225px;z-index:0;"></div>

<div style="margin-top:5em"></div>
 2 over 1     
              code:&lt;div style="border:dashed;background:blue;height:115px;width:45px;z-index:0;position:absolute;"&gt;&lt;div&gt;<br /> 
               &lt;div style="border:double;background:blue;height:45px;width:225px;z-index:1000;position:absolute"&gt;&lt;div&gt;<br /> 
          <div style="border:dashed;background:blue;height:115px;width:45px;z-index:0;position:absolute;"></div>
       
          <div style="border:double;height:45px;background:blue;width:225px;z-index:1000;position:absolute"></div>    
        </p><br /><br />
              <div style="margin-top:5em"></div>
              <p style="">
              z-index property works perfectly when "position:fixed"
                                    or
                            "position:absolute"</p>
        </div>
  </div></div></div>
<div>
    <ul class="pager">
    <li class="previous"><a   style="float:left;"   href="@Href("~/pages/position")" id="prev" >previous</a></li>
    <li class="next"><a   style="float:right;"  href="@Href("~/pages/visibility")" id="next">Next</a></li>
        </ul>
    <br /><br />
</div>
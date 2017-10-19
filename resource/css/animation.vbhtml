@code
    
    Dim xx="@keyframes"
End Code
<style>
    .animation {
        background: url(sss.png);
    }
    div.xfd{
    background:linear-gradient(to top,rgb(23,141,23),rgb(23,191,23));
    width:100px;
    height:45px;
    transition:all 1s ease-in-out;
    }
        div.xfd:hover {
        animation:rotate 1s 1;
        -webkit-animation:rotate 1s 1;
        -o-animation:rotate 1s 1;
        }
        
    input.xxx:hover{
        animation:scale 2s infinite;
        transition:all 1s ease-in-out;
        
    }
    input.xxxx {
        padding: 10px;
        border-radius:33px
    }
    input.xxxx:focus{
        animation:shadow 3s infinite;
    }
</style>
<h1>
    <span  class="label label-success">css Animation</span>
</h1>
  <div style="color:white">
      "transition" property adds keyframes automatically within two instances of value of property.<br />

      <br />
      <p style="font-size:12pt;color:white;background:rgb(131,131,131);font-weight:lighter;text-shadow:none;padding-left:50px">
      synatx:animation:&lt;keyframe_name&gt; &lt;time&gt; &lt;total_time&gt;;<br />
      keyframe_name:It is the name of key frame you have created<br />
      the keyframes are created as follows:<br />
            @xx  &lt;keyframe_name&gt;<br />
               {<br />
                 from{}<br />
                   to{}<br />
               }<br />
              <br />
              OR<br />
          <br />
            @xx &lt;keyframe_name&gt;<br />
              {<br />
                0%{}<br />
              100%{}<br />
              }<br />
      Time: It is time to complete each named keyframes<br /><br />
      Style: It tell the browser that how much time to repeat the animation<br /><br />
       
      </p>
       <br /><br />
      EX:-<br />
          <div>
          
             <p>calling the keyframe animation for once while mouseover:<b>"animation-iteration-count:1;"</b></p>
              <p >
                  <span class="code">
                  
                  <b>
        <span> div.xfd:hover</span> {<br />
                    <span>animation</span>:<span>rotate 1s 1;</span><br />
                       }<br />
        <span>@xx rotate</span>{<br />
                   <span> from</span>{<span>transform</span>:<span>rotate3d(0,0,0,0deg)</span><br />
                    }<br />
                     <span>to</span>{<span>transform</span>:<span>rotate3d(1,-1,0,60deg)</span><br />
                    }<br />
                  }<br />
                  </b></span>
             </p>
                  <div class="xfd">mouse over me</div>
              <br /><br /><br />
              <p>unlimited iteration of keyframes initially :<b>"animation-iteration-count:infinite;"</b></p>
              <p><span class="code"><b>
               <span> @xx scale </span>{<br />
                  <span> 0% </span>{ <span>transform</span>:<span>scale(1)</span> }<br />
                  <span>50% </span>{ <span>transform</span>:<span>scale(1.1)</span> }<br />
                  <span>100% </span>{<span>transform</span>:<span>scale(1)</span> }<br />
                }<br />
                      </b></span></p>
              <input type="submit" class="xxx" value="mouse over me"/>
              <br /><br /><br /><br />
              <p>Unlimited change of box-shadow of focusing the text box:<b>animation-iteration-count:infinite;</b></p>
              <p><span class="code"><b>
               <span> @xx scale </span>{<br />
                  <span> 0% </span>{ <span>box-shadow</span>:<span>0 0 1em black</span> }<br />
                  <span>25% </span>{ <span>box-shadow</span>:<span>0 0 1em cyan</span> }<br />
                  <span>50% </span>{ <span>box-shadow</span>:<span>0 0 1em green</span> }<br />
                  <span>75% </span>{ <span>box-shadow</span>:<span>0 0 1em red</span> }<br />
                  <span>100% </span>{<span>box-shadow</span>:<span>0 0 1em black</span> }<br />
                }<br />
                      </b></span></p>
              <input type="text" class="xxxx" value=""/>
              
            <br />
              <br /><br /><br /><br />
             
        </div>
  </div>
<div id="nxn">
    <ul id="bnav">
    <li><a  style="float:left;"   href="@Href("~/pages/transition")" id="prev" >previous</a></li>
    <li><a   style="float:right;"  href="@Href("~/pages/transform")" id="next">Next</a></li>
        </ul>
    <br /><br />
</div>
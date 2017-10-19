
<style>
    .transition {
        background: url(sss.png);
    }
 div.xfd{
    background:linear-gradient(to top,rgb(23,141,23),rgb(23,191,23));
    width:100px;
    height:45px;
    transition:all 1s ease-in-out;
    }
        div.xfd:hover{
             background:linear-gradient(to bottom,rgb(23,141,23),rgb(23,191,23));
    width:200px;
    height:65px;
        }
    input.xxx{
        box-shadow:0 0 1px cyan;
        transition:all 1s ease-in-out;
    }
    input.xxx:hover{
        box-shadow:0 0 2em cyan;
        transition:all 1s ease-in-out;
    }
     input.xxxx{
         padding:25px;
        box-shadow:0 0 1px green;
        transition:all 1s ease-in-out;
       
            
    }
    input.xxxx:hover{
        box-shadow:0 0 1em cyan;
        transition:all 1s ease-in-out;
      
    }
    input.xxxx:focus{
        box-shadow:0 0 1em red;
        transition:all 1s ease-in-out;

      
    }
</style>
<ul class="fnt">
<li>Transition</li>
</ul>
  <div>
      "transition" property adds keyframes automatically within two instances of value of property.<br />

      <br />
      <p>
      <p class="code">
  synatx:transition:&lt;property_name&gt; &lt;time&gt; &lt;style&gt;;<br />
  property_name: any name of property like background,color,text-shadow or
                "all" this keyword transitions all the propertyy listed<br />
  Time: it is the duration of transition ex: 1s,0.4s,3s etc.<br />
  Style: it defines that in which style it must do the transition 
         ex: ease-in,ease-out,ease-in-out etc.<br /><br />
       
      </p></p>
       <br /><br />
      EX:-<br />
          <div>
          
             
                  <div class="xfd">mouse over me</div>
              <br />
              <input type="submit" class="xxx" value="mouse over me"/>
              <br /><br />
              <input type="text" class="xxxx" value=""/>
              
            <br />
              <br />
             
        </div>
  </div>
<div>
  
    <ul id="bnav">
    <li ><a  style="float:left;"   href="@Href("~/pages/liststyle")" id="prev" >previous</a></li>
    <li><a   style="float:right;"  href="@Href("~/pages/animation")" id="next">Next</a></li>
        </ul>
    <br /><br />
</div>
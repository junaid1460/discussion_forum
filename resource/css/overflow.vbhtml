
<style>
    .overflow {
        background: url(sss.png);
    }
    #oy, #ox {
    width:60%;
    height:222px;
    }
    #oy {

    overflow-y:no-display
    }
    #ox {
    overflow-x:hidden
    }
    #o {
    overflow:hidden;
    }
</style>
<script type="text/javascript">

</script>

<ul class="list-group">
    <li class="list-group-item">overflow</li>
    <li class="list-group-item">overflow-y</li>
    <li class="list-group-item">overflow-x</li>
</ul>

<div class="panel panel-primary">
            <div class="panel-heading ">
              <h3 class="panel-title">overflow</h3>
            </div>
            <div class="panel-body">
  <div>
      overflow is used when it is necessory to prevent page from scrolling<br />
      it can have value like scroll,hidden,no-content,no-display etc.
      <iframe id="o" src="~/pages/overflowif1" style="-webkit-overflow-scrolling:touch">

      </iframe>
   </div></div></div>

<div class="panel panel-primary">
            <div class="panel-heading ">
              <h3 class="panel-title">overgflow-x</h3>
            </div>
            <div class="panel-body">
  <div>
      overflow-x is used when it is necessory to prevent page from scrolling in X axis<br />
      it can have value like scroll,hidden,no-content,no-display etc.
      <iframe id="ox" src="~/pages/overflowif1" style="-webkit-overflow-x:hidden">

      </iframe>
   </div></div></div>

<div class="panel panel-primary">
            <div class="panel-heading ">
              <h3 class="panel-title">overflow-y</h3>
            </div>
            <div class="panel-body">
  <div>
      overflow is used when it is necessory to prevent page from scrolling in Y axis<br />
      it can have value like scroll,hidden,no-content,no-display etc.
       <iframe id="oy" src="~/pages/overflowif1" style="-webkit-overflow-y:hidden">

      </iframe>
   </div>
 <b> might not work with chrome,safari(-webkit- framework)</b></div></div>
<div>
   
    <ul class="pager">
    <li class="previous"><a   style="float:left;"   href="@Href("~/pages/float")" id="prev" >previous</a></li>
    <li class="next"><a   style="float:right;"  href="@Href("~/pages/textdecoration")" id="next">Next</a></li>
        </ul>
    <br /><br />
</div>
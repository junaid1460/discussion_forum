
<style>
    .lll li {
        color:white;cursor:default;
    }
    .intro {
        background: url(sss.png);
    }
</style>
<h1>
    <span  class="label label-success">css introduction</span>
</h1>
    

<script type="text/javascript">
   
</script>
<h3 style="font-weight:lighter;font-size:22pt;">css(cascading style sheet):-</h3>
<h2 style="font-size:12pt;font-weight:lighter;">css is the method to define the presentation of built in html elements of the page.
     Using css you can present the elements very attractively.<br />
    
    </h2>
    <ol class="list-group">
        <li class="list-group-item active">you can embed style sheet`as</li>
        <li class="list-group-item">attribute or</li>
        <li class="list-group-item">within &lt;style&gt;&lt/style&gt or</li>
        <li class="list-group-item">in an external file with .css extension</li>
     </ol> 
    In this tutorial I am gonna teach you about css3(version 3)<br />
    for example consider this page,right click and click the inspect element or view page source.
    you can see the html construction of whole page in the head tag you can see the links for js or css
    click on css and see what we used.<br /><br />
   
    

 <p style="font-size:14pt;">example :</p>
<p style="font-size:12pt">Within &lt;style&gt; tag :</p>
<pre class="code">
     <span>H1</span>{
                <span>color</span>:<span>red</span>;
           <span>background</span>:<span>black</span>;
            <span>font-size</span>:<span>12pt</span>;
          <span>font-family</span>:<span>arial</span>
        }
</pre>
<p style="font-size:12pt">Inline attribute :</p>
<pre class="code">
    &lt;<span>p</span> <span>style=</span><span>"</span><span>color</span>:<span>green</span>;<span>"</span>&gt;Hello world!&lt;/<span>p</span>&gt;
</pre>
<p style="font-size:12pt">The efficient way to include styles in external file as follows :

</p>

<pre class="code">
    &lt<span>link</span> <span>rel=<span>"stylesheet"</span></span> <span>href=<span>"FILE NAME.css"</span></span> /&gt;
</pre>
<p>in case of xhtml every stylesheets should be maintained in seperate files</p>
<div>
    <ul class="pager label-success" style="padding:5px">
    <li class="previous"><a   href="@Href("~/")"  >home</a></li>
    <li class="next"><a    href="@Href("~/pages/font")">Next</a></li>
        </ul>
<br /><br /></div> 
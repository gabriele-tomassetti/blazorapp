function check() {          
      document.getElementById("main_text").value =
      DotNet.invokeMethod('BlazorApp','RememberTheTruth',
        document.getElementById("main_text").value);
}
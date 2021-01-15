function pruebaONetStatic() {
    DotNet.invokeMethodAsync("BlazorAppPeliculas.Client", "obtenerCurrentCount").then(resultado => { console.log("conteo desde javaScript" + resultado); });
}

function pruebaDoteNetInstancia(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}
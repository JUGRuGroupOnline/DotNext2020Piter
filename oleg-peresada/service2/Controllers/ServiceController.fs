namespace service2.Controllers

open System
open System.Net.Http
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging

[<ApiController>]
[<Route("/")>]
type ServiceController (logger : ILogger<ServiceController>) =
    inherit ControllerBase()

    [<HttpGet>]
    member __.Get() : Async<String> =
        async {
            let http = new HttpClient()
            let! response = http.GetAsync(Environment.GetEnvironmentVariable("URL_SERVICE")) |> Async.AwaitTask
            let! content = response.Content.ReadAsStringAsync() |> Async.AwaitTask
            return if (content = "На") then content + " .Net" else "Ответ не соответствует ожидаемому"
        }
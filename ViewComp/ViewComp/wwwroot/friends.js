document.querySelector("#load-friends-button").addEventListener("click", async () => {
    var response = await fetch("friends-list", { method: "GET" });
    var data = await response.text();

    document.querySelector("#list").innerHTML = data;

})
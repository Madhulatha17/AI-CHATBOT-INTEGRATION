async function sendMessage() {

    const message =
        document.getElementById("message").value;

    const response =
        await fetch("/Chat/SendMessage", {
            method: "POST",
            headers: {
                "Content-Type":
                    "application/json"
            },
            body: JSON.stringify({
                userMessage: message
            })
        });

    const data =
        await response.json();

    document.getElementById(
        "chatWindow"
    ).innerHTML +=
        `<p><b>You:</b> ${data.userMessage}</p>
         <p><b>Bot:</b> ${data.botResponse}</p>`;
}

// Setup an event listener to make an API call once auth is complete
function onLinkedInLoad() {
    IN.Event.on(IN, "auth", shareContent);
}

// Handle the successful return from the API call
function onSuccess(data) {
    console.log(data);
}

// Handle an error response from the API call
function onError(error) {
    console.log(error);
}

// Use the API call wrapper to share content on LinkedIn
function shareContent() {

    // Build the JSON payload containing the content to be shared
    var payload = {
        "comment": "Check out developer.linkedin.com! http://linkd.in/1FC2PyG",
        "visibility": {
            "code": "anyone"
        }
    };

    IN.API.Raw("/people/~/shares?format=json")
      .method("POST")
      .body(JSON.stringify(payload))
      .result(onSuccess)
      .error(onError);
}

(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) { return; }
    js = d.createElement(s); js.id = id;
    js.src = "//platform.linkedin.com/in.js";
    js.text = "api_key: 7561qgvc6f9yq8 \n authorize: true \n onLoad: onLinkedInLoad"
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'linkedin-jssdk'));
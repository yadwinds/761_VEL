var switchTo5x=true;

(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) { return; }
    js = d.createElement(s); js.id = id;
    js.src = "http://w.sharethis.com/button/buttons.js";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'sharethis-sdk'));

stLight.options({publisher: "999d2b62-5b1c-41a0-89b9-b5eb2e524b10", shorten: false, doNotHash: false, doNotCopy: false, hashAddressBar: false});
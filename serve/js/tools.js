function transferSalt(type){
    if(type == "NEW"){

    }else{
        if(localStorage.getItem("tranferSalt").length > 0) return localStorage.getItem("tranferSalt");
        else{
            
        }
    }
}
function httpGet(theUrl, headersKey, headersValue)
{
    var xmlHttp = new XMLHttpRequest();
    for(var i = 0; i < headersKey.length; i++){
        if(headersKey.length != headersValue.length) break;

        xmlHttp.setRequestHeader(headersKey[i], headersValue[i]);

    }
    xmlHttp.open("GET", theUrl, false );
    xmlHttp.send( null );
    return xmlHttp.responseText;
}
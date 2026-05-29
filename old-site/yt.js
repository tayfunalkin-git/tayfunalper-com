var channelID = "UCEofNe2qCJLIPpRLMVXG9Mw";
var reqURL = "https://www.youtube.com/feeds/videos.xml?channel_id=";
$.getJSON("https://api.rss2json.com/v1/api.json?rss_url=" + encodeURIComponent(reqURL) + channelID, function (data) {
    var link = data.items[0].link;
    var id = link.substr(link.indexOf("=") + 1);
    $("#youtube_video").attr("src", "https://youtube.com/embed/" + id + "?controls=0&showinfo=1&rel=0");
    $("#youTubeLink").attr("href", "https://youtube.com/watch?v=" + id);
    $("#youTubeLink").attr("target", "_blank");

});

//some vars
var currentSong = 0;
var audioplayer = document.getElementById("audioPlayer");
var playlist = document.getElementsByTagName("li");
var playa = document.getElementsByClassName("a");
//help me to use for each
var playalist = [];
for (var i = 0; i < playa.length; i++) {
    playalist.push(playa[i]);
}

//some console to check stuff
console.log("play a");
console.log(playa);
console.log("play a in an array:");
console.log(playalist);
console.log("play list:");
console.log(playlist);
console.log("audio player:");
console.log(audioplayer);

//if clicks a it plays song ,color it and precolor the last one
playalist.forEach(function (elem) {
    elem.addEventListener("click", function (e) {
        e.preventDefault();
        audioplayer.src = this;
        console.log(this);
        audioplayer.play();
        for (var i = 0; i < playalist.length; i++) {
            playa[i].parentElement.classList.remove("current-song");
        }
        currentSong = playalist.indexOf(this);
        this.parentElement.classList.add("current-song");
    });
});

//put next track
audioplayer.addEventListener("ended", nextTrack);

//functions
function nextTrack() {
    currentSong++;
    if (currentSong == playa.length) {
        currentSong = 0;
        playa[playa.length - 1].parentElement.classList.remove("current-song");
    }
    else
        playa[currentSong - 1].parentElement.classList.remove("current-song");
    playa[currentSong].parentElement.classList.add("current-song")
    audioplayer.src = playa[currentSong].href;
    audioplayer.play();
}

function preTrack() {
    currentSong--;
    if (currentSong == -1) {
        currentSong = playa.length-1;
        playa[0].parentElement.classList.remove("current-song");
    }
    else
        playa[currentSong+1].parentElement.classList.remove("current-song");
    playa[currentSong].parentElement.classList.add("current-song")
    audioplayer.src = playa[currentSong].href;
    audioplayer.play();
}
let NAME_ARTIST = '';
let TRACKS = [];
let POINTS = 0;
let trackLength = 1;

const getGenres = async () => {
    const response = await fetch('https://localhost:7196/api/game/getgenres');
    const genres = await response.json();
    let html = '';

    genres.forEach(genre => {
        html += `<a href="#" class="list-group-item list-group-item-action">${genre}</a>`;
    });

    document.getElementById('listGenres').innerHTML = html;
}

const showArtistTrack = (index = 0) => {
    let track = document.getElementById('track');
    track.innerHTML = TRACKS[index]

    document.getElementById('card1').style.display = 'block';
    document.getElementById('card2').style.display = 'none';
    document.getElementById('alertError').style.display = 'none';
    document.getElementById('alertSuccess').style.display = 'none';

    document.getElementById('number').innerHTML = index + 1;

}

const viewPoints = () => {
    document.getElementById('points').innerText = POINTS;
}

const isTheArtist = (artist) => {
    return artist === NAME_ARTIST;
}

const getRandomArtistsByGenre = async (genre) => {
    const response = await fetch(`https://localhost:7196/api/Game/GetRandomArtistsByGenre/${genre}`);
    const data = await response.json();
    trackLength = 1;

    NAME_ARTIST = data.name;
    TRACKS = data.tracks;
    document.getElementById('total').innerHTML = TRACKS.length;
    showArtistTrack();
}

const clear = () => {
    document.getElementById('response').value = '';
    document.getElementById('track').innerHTML = '';
    card1.style.display = 'none';
    card2.style.display = 'block';
}

const viewMessageError = (message) => {
    const messageError = document.getElementById('messageError');
    messageError.innerText = message;
    messageError.style.display = 'block';
}

document.addEventListener('DOMContentLoaded', () => {
    getGenres();
    viewPoints();
})

document.getElementById('listGenres').addEventListener('click', async (e) => {
    const genre = e.target.innerText;
    getRandomArtistsByGenre(genre)
});

document.getElementById('btnCheck').addEventListener('click', () => {
    const artist = document.getElementById('response').value;
    showArtistTrack(trackLength);
    trackLength++;
    if (isTheArtist(artist)) {
        POINTS += 1;
        viewPoints();
        clear();
        document.getElementById('alertSuccess').style.display = 'block';
    }
    if (trackLength > TRACKS.length) {
        clear();
        document.getElementById('alertError').style.display = 'block';
    }
});
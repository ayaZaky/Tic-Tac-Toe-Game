function hideLoader() {
    setTimeout(() => {
        let loadingScreen = document.getElementById("loading-screen");
        let content = document.getElementById("content");

        if (loadingScreen) loadingScreen.style.display = "none";
        if (content) content.style.display = "block";
    }, 1000);  
}

document.addEventListener("DOMContentLoaded", function () {
    let loadingScreen = document.getElementById("loading-screen");

    if (!sessionStorage.getItem("loaded")) {
        setTimeout(() => {
            if (loadingScreen) loadingScreen.style.display = "none";
            sessionStorage.setItem("loaded", "true");

  
            window.location.href = "/Game/Index";  
        }, 1000); 
    } else {
        if (loadingScreen) loadingScreen.style.display = "none";
    }
});

document.addEventListener("DOMContentLoaded", function () {
    let soundFiles = ["play1.mp3", "play2.mp3", "win.mp3"]; // ضيفي كل الأصوات هنا

    window.sounds = {}; // مكان تخزين الأصوات بعد تحميلها

    soundFiles.forEach(sound => {
        fetch(`/sounds/${sound}`)
            .then(response => response.blob())
            .then(blob => {
                let url = URL.createObjectURL(blob);
                window.sounds[sound] = new Audio(url);
                window.sounds[sound].volume = 1.0; // تأكد إن الصوت عالي
                console.log(`Sound success: ${sound}`);
            })
            .catch(error => console.error(`Sound failed : ${sound}`, error));
    });
});

let clickSound = new Audio('/sounds/play2.mp3');  
function playClickSound(event, element) {
    event.preventDefault();
    clickSound.currentTime = 0;

    let playPromise = clickSound.play();

    if (playPromise !== undefined) {
        playPromise
            .then(() => {

                setTimeout(() => submitForm(element), 500);
            })
            .catch(error => {
                console.error("Sound failed ", error);

                submitForm(element);
            });
    } else {

        submitForm(element);
    }
}

function submitForm(element) {
    if (element.tagName === "A") {
        window.location.href = element.href;
    } else if (element.tagName === "BUTTON") {
        let form = element.closest("form");
        if (form) {
            let hiddenInput = document.createElement("input");
            hiddenInput.type = "hidden";
            hiddenInput.name = element.name;
            hiddenInput.value = element.value;
            form.appendChild(hiddenInput);
            form.submit();
        }
    }
}

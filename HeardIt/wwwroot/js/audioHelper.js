window.PlayAudio = (elementName, linkedId) => {
    const player = document.getElementById(elementName);
    if(linkedId) {
        let element = document.getElementById(linkedId)
          
        element.classList.add("border-purple-500")
        element.classList.add("border-2")
        element.classList.add("border-opacity-50")

    }
    player.play();
    player.onended = (e) => {
        if(linkedId) {
            let element = document.getElementById(linkedId)
            element.classList.remove("border-purple-500")
            element.classList.remove("border-2")
            element.classList.remove("border-opacity-50")
        }

        window.dotnetHelper.invokeMethodAsync('BlazorSample', 'UpdateMessageCaller');
    }
}

window.updateAudioCaller = (localHelper) => {
    window.dotnetHelper = localHelper;
}


window.PauseAudio = (elementName) => {
    document.getElementById(elementName).pause();
}
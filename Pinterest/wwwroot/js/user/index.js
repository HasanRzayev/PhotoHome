const draggerArea = document.getElementById('dragger');
const inputField = document.getElementById('fileInputField');
const dragText = document.getElementById('drag-text');
const fileDelete = document.getElementById('fileDelete');
const browseFile = document.getElementById('browseFile');

const inputClick = () => {
    inputField.value = ""
    inputField.click();
};

inputField.addEventListener('change', function (e) {
    file = this.files[0];
    fileHandler(file);
});

draggerArea.addEventListener('dragover', (e) => {
    e.preventDefault()
    dragText.textContent = "Release to upload image"
});

draggerArea.addEventListener('dragleave', () => {
    dragText.textContent = "Drag and drop file"
});

draggerArea.addEventListener('drop', (e) => {
    e.preventDefault()
    file = e.dataTransfer.files[0];
    fileHandler(file)
});

const deleteHandler = () => {
    const draggerElement = `<div class="icon"><i class="fa-solid fa-images"></i></div><h3 id="drag-text">Drag and drop file</h3><button class="browseFile py-1 px-3" id="browseFile" onclick="inputClick()">Browse</button><input type="file" hidden id="fileInputField"/>`;
    draggerArea.innerHTML = draggerElement
    draggerArea.classList.remove('active');
};

const fileHandler = (file) => {
    const validExt = ["image/jpeg", "image/jpg", "image/png"]
    if (validExt.includes(file.type)) {
        const fileReader = new FileReader();
        fileReader.onload = () => {
            const fileURL = fileReader.result;
            let imgTag = `<img src=${fileURL} alt=""/><div id="fileDelete"><i class="fa-solid fa-trash-can" onclick={deleteHandler()}></i></div>`
            draggerArea.innerHTML = imgTag;
        }
        fileReader.readAsDataURL(file);
        draggerArea.classList.add('active')
    } else {
        draggerArea.classList.remove('active');
        dragText.textContent = "Drag drop file"
    }
};
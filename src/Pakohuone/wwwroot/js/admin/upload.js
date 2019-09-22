$(document).ready(() => {
  $('#upload-button').click(showUploadModal);
});

const showUploadModal = () => {
  $('#upload-modal').modal().show();
}

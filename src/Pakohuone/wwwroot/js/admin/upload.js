$(document).ready(() => {
  $('#upload-button').click(showUploadModal);
  bsCustomFileInput.init();
});

const showUploadModal = () => {
  $('#upload-modal').modal().show();
}

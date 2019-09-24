$(document).ready(() => {
  $('#delete-button').click(showDeleteModal);
});

const showDeleteModal = () => {
  $('#delete-modal').modal().show();
}

$(document).ready(() => {
  initializeDataTables();
});

const initializeDataTables = () => {
  const tables = document.getElementsByClassName('ph-table');

  for (const table of tables) {
    $(table).DataTable({
      'language': {
        "lengthMenu": "Showing _MENU_ items per page",
        "zeroRecords": "No items found",
        "info": "Showing page _PAGE_ of _PAGES_",
        "infoEmpty": "Nothing matches the filter",
        "infoFiltered": "(filtered from _MAX_ total items)"
      }
    });
  }
}

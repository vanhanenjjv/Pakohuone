$(document).ready(() => {
  $('#sidebar-toggle').click(toggleSidebar);
});

const toggleSidebar = () => {
  $('#wrapper').toggleClass('toggled');
  $('#sidebar-toggle').toggleClass('active');
}

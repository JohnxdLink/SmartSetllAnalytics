function showContent(contentType) {
    // Hide all content divs
    document.querySelectorAll('.home-content, .capital-content').forEach(function (el) {
        el.style.display = 'none';
    });

    // Show the selected content
    document.querySelector('.' + contentType + '-content').style.display = 'flex';
}
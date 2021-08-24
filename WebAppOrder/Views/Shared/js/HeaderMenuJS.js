window.addEventListener('load', () => {

    const menuBtn = document.getElementById("menuBtn");
    const menu = document.getElementById("menu");


    menuBtn.addEventListener('click', function () {
        (menu.style.display === 'block') ?
            menu.style.display = 'none' :
            menu.style.display = 'block';
    });

});
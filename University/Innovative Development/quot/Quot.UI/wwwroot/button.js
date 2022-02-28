const button = document.getElementById('post-btn');

button.addEventListener('click', async _ => {
    if (el) {
        el.addEventListener('click', swapper, false);
    }
    try {
        const response = await fetch('https://www.quot.live/api/text', {
            method: 'post',
            body: {
                "text": document.getElementById('textbox_id').value
            }
        });
        console.log('Completed!', response);
    } catch (err) {
        console.error(`Error: ${err}`);
    }
});
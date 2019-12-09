// Send GET request to the given URL
$('[data-get]').click(function (e) {
    e.preventDefault();
    location = $(this).data('get');
});

// Escape regular expression
function escapeRegExp(string) {
    return string.replace(/[.*+?^${}()|[\]\\]/g, '\\$&');
}

// Reset form (reload page)
$('[type=reset]').click(function (e) {
    e.preventDefault();
    location = location;
});

// Convert input to uppercase
$('[data-upper]').on('input', function (e) {
    let a = this.selectionStart;
    let b = this.selectionEnd;
    this.value = this.value.toUpperCase();
    this.setSelectionRange(a, b);
});

// Prevent non-numeric characters
$('[data-number]').on('keypress', function (e) {
    let re = /[0123456789\.\-]/;
    if (!re.test(e.key)) {
        e.preventDefault();
    }
});

// Send POST request to the given URL
$('[data-post]').click(function (e) {
    e.preventDefault();
    let f = $('<form>')[0];
    $('body').append(f);
    f.method = 'post';
    f.action = $(this).data('post');
    f.submit();
});

// Check all targeted checkboxes
$('[data-check]').click(function (e) {
    e.preventDefault();
    let name = $(this).data('check');
    $('[name=' + name + ']').prop('checked', true);
});

// Uncheck all targeted checkboxes
$('[data-uncheck]').click(function (e) {
    e.preventDefault();
    let name = $(this).data('uncheck');
    $('[name=' + name + ']').prop('checked', false);
});


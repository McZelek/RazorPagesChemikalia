const thElements = document.querySelectorAll('th');

thElements.forEach(thElement => {
    thElement.addEventListener('click', handleSort);
});

function handleSort(event) {
    const columnIndex = Array.from(event.target.parentNode.children).indexOf(event.target);
    const isSorted = event.target.classList.contains('sorted');
    const isAscending = event.target.classList.contains('ascending');

    function sortTableByColumn(table, columnIndex, isAscending) {
        const rows = Array.from(table.tBodies[0].rows);

        rows.sort((a, b) => {
            const aValue = a.cells[columnIndex].textContent;
            const bValue = b.cells[columnIndex].textContent;
            return isAscending ? aValue.localeCompare(bValue) : bValue.localeCompare(aValue);
        });

        table.tBodies[0].append(...rows);
    }

    const table = document.querySelector('table');

    thElements.forEach(thElement => {
        thElement.classList.remove('sorted', 'ascending');
    });

    event.target.classList.add('sorted');
    if (isSorted && isAscending) {
        event.target.classList.remove('ascending');
        sortTableByColumn(table, columnIndex, false);
    } else {
        event.target.classList.add('ascending');
        sortTableByColumn(table, columnIndex, true);
    }
}


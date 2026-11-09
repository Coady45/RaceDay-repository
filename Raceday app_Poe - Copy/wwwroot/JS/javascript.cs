document.addEventListener("DOMContentLoaded", function() {

    console.log("RaceDay website loaded successfully.");

    // Confirm before deleting an item
    document.querySelectorAll(".delete-button").forEach(button => {

    button.addEventListener("click", function(event) {

        const confirmDelete = confirm(
            "Are you sure you want to delete this item?"
        );

        if (!confirmDelete)
        {
                event.preventDefault();
        }

    });

});

});
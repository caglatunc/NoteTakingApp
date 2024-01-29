# NoteTakingApp-Desktop

This is a desktop note-taking application built using C# and Windows Forms. It allows users to conveniently create, edit, delete, and save notes.

## Features
**__Data Structure__**: Utilizes a DataTable named "notes" to store data, consisting of three columns: Title, Note, and Date.

**Form Initialization**: Upon form loading, necessary columns are defined for the DataTable, which is then bound to a DataGridView control named "previousNotes".

**Adding New Notes**: Clicking the "New Note" button clears the title and note input fields, preparing for the addition of a new note.

**Editing Notes**: Double-clicking a note row in the DataGridView or clicking the "Load" button populates the corresponding title and note fields, allowing for note editing.

**Saving Notes**: Clicking the "Save" button updates the information of the selected note if in editing mode; otherwise, it adds a new note. After saving, input fields are cleared, and editing mode is exited.

**Deleting Notes**: Clicking the "Delete" button removes the selected note's row from the DataTable.

**Error Handling**: In case of any errors, the application displays a "Not a valid note" message to the user.

https://github.com/caglatunc/NoteTakingApp/assets/95507765/28c3dabb-e511-4139-9a94-e9fd8c284212


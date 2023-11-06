const fs = require("fs");
const filename = "example.txt";

fs.writeFileSync(filename, "This is a sample file created with Node.js!");
console.log("File contents:\n" + fs.readFileSync(filename, "utf-8"));

fs.appendFileSync(filename, "\nThis text is appended to the file.");
console.log("Updated file contents:\n" + fs.readFileSync(filename, "utf-8"));

fs.renameSync(filename, "newfile.txt");

if (fs.existsSync("newfile.txt")) {
  console.log("File renamed and deleted successfully.");
  fs.unlinkSync("newfile.txt");
} else {
  console.log("Error renaming the file.");
}

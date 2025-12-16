const API_BASE = "https://localhost:7074/api";

async function loadCourses() {
  const res = await fetch(`${API_BASE}/courses`);
  const courses = await res.json();

  const ul = document.getElementById("courses");
  ul.innerHTML = "";

  courses.forEach(c => {
    const li = document.createElement("li");
    li.innerText = `${c.name} - ${c.description}`;
    ul.appendChild(li);
  });
}

async function loadReport() {
  const res = await fetch(`${API_BASE}/enrolments/report`);
  const report = await res.json();

  const ul = document.getElementById("report");
  ul.innerHTML = "";

  report.forEach(r => {
    const li = document.createElement("li");
    li.innerText = `${r.courseName}: ${r.studentsCount} students`;
    ul.appendChild(li);
  });
}

loadCourses();
loadReport();

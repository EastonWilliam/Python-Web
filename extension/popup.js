document.addEventListener("DOMContentLoaded", () => {
  const toggle = document.getElementById("toggle");

  chrome.storage.sync.get(["enabled"], (res) => {
    toggle.checked = res.enabled ?? true;
  });

  toggle.addEventListener("change", () => {
    chrome.storage.sync.set({
      enabled: toggle.checked
    });
  });
});
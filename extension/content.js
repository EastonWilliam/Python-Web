// Regex: matches ANY non-Latin script characters
const NON_LATIN_REGEX = /[^\u0000-\u007F\u00A0-\u024F\s.,!?'"()\-:;0-9]/g;
// Updated regex to allow basic punctuation and numbers, while still blocking non-Latin scripts
// Check if a string contains non-Latin characters
function hasNonLatin(text) {
  return NON_LATIN_REGEX.test(text);
}

// Remove or clean text nodes
function cleanNode(node) {
  if (!node || !node.nodeValue) return;

  if (hasNonLatin(node.nodeValue)) {
    node.nodeValue = "";
  }
}

// Walk DOM and clean text nodes
function scanDOM(root = document.body) {
  const walker = document.createTreeWalker(
    root,
    NodeFilter.SHOW_TEXT,
    null,
    false,
  );

  let node;
  while ((node = walker.nextNode())) {
    cleanNode(node);
  }
}

// Remove entire elements if they contain only non-Latin text
function removeBadElements() {
  const allElements = document.querySelectorAll("body *");

  allElements.forEach((el) => {
    if (el.children.length === 0) {
      const text = el.textContent?.trim();

      if (text && hasNonLatin(text)) {
        el.remove();
      }
    }
  });
}

// Run full cleanup
function runCleanup() {
  scanDOM();
  removeBadElements();
}

// Initial run
runCleanup();

// Watch for dynamic UI updates (React, etc.)
const observer = new MutationObserver(() => {
  runCleanup();
});

observer.observe(document.body, {
  childList: true,
  subtree: true,
});

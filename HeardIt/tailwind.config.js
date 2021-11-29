module.exports = {
  mode: 'jit',
  purge: [
    './wwwroot/index.html',
    './**/*.razor',
  ],
  darkMode: 'media', // or 'media' or 'class'
  theme: {
    extend: {},
  },
  variants: {
    extend: {},
  },
  plugins: [
    // ...
    require('@tailwindcss/forms'),
  ],
}

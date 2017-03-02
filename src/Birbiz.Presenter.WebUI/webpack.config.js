/// <binding BeforeBuild='Run - Development' />
var isProd = (process.env.NODE_ENV === 'production');

if (!isProd) {
    module.exports = require('./webpack.config.dev.js');
} else {
    module.exports = require('./webpack.config.prod.js');
}
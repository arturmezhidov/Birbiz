var webpack = require("webpack");
var path = require("path");
var ForkCheckerPlugin = require('awesome-typescript-loader').ForkCheckerPlugin;

console.log('@@@@@@@@@@@@@@@ START WEBPACK BUILD @@@@@@@@@@@@@@@');

module.exports = {

    resolve: {
        extensions: ["", ".js", ".ts", ".html"]
    },
    module: {
        loaders: [
          {
              test: /\.ts$/,
              //exclude: /\/node_modules\//,
              loader: "awesome-typescript-loader!angular2-template-loader!angular2-load-children-loader",
            //  include: /ClientApplication/
          },
            {
                test: /\.html$/,
                loader: 'raw-loader'
            }
        ],
        //noParse: [
        //  /\/node_modules\/[^!]+$/
        //]
    },
    context: __dirname + "/ClientApplication",
    entry: {
        polyfills: './src/polyfills',
       // vendor: './src/vendor',
        main: './src/main'
    },
    output: {
        path: path.resolve(__dirname, "wwwroot/app"),
        publicPath: "/app/",
        filename: "[name].js",
        chunkFilename: "[name].chunk.js"
    },

    plugins: [
      new ForkCheckerPlugin()
    ]

    //#region Watching
    //watch: true,
    //watchOptions: {
    //    aggregateTimeout: 300 // 300 default
    //}
    //#endregion 
};
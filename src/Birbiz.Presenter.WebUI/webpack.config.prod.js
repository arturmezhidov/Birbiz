var webpack = require("webpack");
var merge = require("webpack-merge");
var config = require("./webpack.config");

module.exports = merge({}, config, {
    plugins: [
      new webpack.LoaderOptionsPlugin({
          minimize: true,
          debug: false
      }),
      new webpack.optimize.UglifyJsPlugin({
          compress: {
              warnings: false
          },
          output: {
              comments: false
          },
          sourceMap: true
      })
    ],
    devtool: "sourcemap"
});
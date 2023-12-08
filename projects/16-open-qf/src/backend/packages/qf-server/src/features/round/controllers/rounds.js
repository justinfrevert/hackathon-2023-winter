const { extractPage } = require("../../../utils/extractPage");
const { qf: { getRoundCol } } = require("@open-qf/mongo");

async function getRounds(ctx) {
  const { page, pageSize } = extractPage(ctx);
  if (pageSize === 0 || page < 0) {
    ctx.status = 400;
    return;
  }

  const col = await getRoundCol();
  const items = await col
    .find({}, { projection: { _id: 0 } })
    .sort({ id: -1 })
    .skip(page * pageSize)
    .limit(pageSize)
    .toArray();
  let total = await col.estimatedDocumentCount();

  ctx.body = {
    items,
    page,
    pageSize,
    total,
  };
}

module.exports = {
  getRounds,
}
